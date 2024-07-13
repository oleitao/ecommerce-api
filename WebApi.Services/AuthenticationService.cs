﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using WebApi.Entities.ConfigurationModels;
using WebApi.Entities.Exceptions;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class AuthenticationService : IAuthenticationService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IOptions<JwtConfiguration> _configuration;
        private readonly JwtConfiguration _jwtConfiguration;

        private User? _user;

        public AuthenticationService(IMapper mapper, UserManager<User> userManager, IOptions<JwtConfiguration> configuration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;

            _jwtConfiguration = _configuration.Value;
        }

        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private SigningCredentials GetSigningCredentials()
        {
            var secretKey = Environment.GetEnvironmentVariable("SECRET");
            if (secretKey is null)
                throw new Exception();

            var key = Encoding.UTF8.GetBytes(secretKey);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken
                (
                    issuer: _jwtConfiguration.ValidIssuer,
                    audience: _jwtConfiguration.ValidAudience,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtConfiguration.Expires)),
                    signingCredentials: signingCredentials
                );

            return tokenOptions;
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName)
            };

            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }


        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration)
        {
            var user = _mapper.Map<User>(userForRegistration);

            var userCreated = await _userManager.CreateAsync(user, userForRegistration.Password);
            if (userCreated.Succeeded)
            {
                Uri uri = new Uri($"https://localhost:8080/api/v1.1/authentication/accountvalidationemail/?Email={user.Email}");
                var client = new HttpClient { BaseAddress = uri };
                await client.GetAsync(uri);

                if (userForRegistration.Roles is null)
                    await _userManager.AddToRolesAsync(user, new string[] { "User" });
                else
                    await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
            }

            return userCreated;
        }


        public async Task<bool> LoginUser(UserForAuthenticationDto userForAuth)
        {
            _user = await _userManager.FindByNameAsync(userForAuth.UserName);
            if(_user is null)
                throw new UserNotFoundException(userForAuth.UserName);

            var result = await _userManager.CheckPasswordAsync(_user, userForAuth.Password);
            if (result is bool check && check.Equals(true))
                throw new Exception($"{nameof(LoginUser)}: Authentication failed. Wrong user name or password.");

            return result;
        }

        public async Task<TokenDto> GenerateToken(bool populateExp)
        {
            var signingCredentials = GetSigningCredentials();

            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            var refreshToken = GenerateRefreshToken();

            if (_user is null)
                throw new UserNotFoundException();

            if (populateExp)
            {
                _user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);
                _user.RefreshToken = refreshToken;
            }

            await _userManager.UpdateAsync(_user);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return new TokenDto(accessToken, refreshToken);
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32]; using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber); return Convert.ToBase64String(randomNumber);
            }
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var secretKey = Environment.GetEnvironmentVariable("SECRET");
            if (secretKey is null)
                throw new Exception();

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ValidateLifetime = true,

                ValidIssuer = _jwtConfiguration.ValidIssuer,
                ValidAudience = _jwtConfiguration.ValidAudience
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);

            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null ||
                !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }

        public async Task<TokenDto> RefreshToken(TokenDto token)
        {
            var principal = GetPrincipalFromExpiredToken(token.AccessToken);

            var user = await _userManager.FindByNameAsync(principal.Identity.Name);

            if (user == null || user.RefreshToken != token.RefreshToken ||
                user.RefreshTokenExpiryTime <= DateTime.Now)
                throw new RefreshTokenBadRequest();

            _user = user;

            return await GenerateToken(populateExp: false);
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(User user)
        {
            return await _userManager.GenerateEmailConfirmationTokenAsync(user);
        }
    }
}