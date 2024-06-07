﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApi.Contracts;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class AuthenticationService : IAuthenticationService
    {
        private readonly ILoggerManager _logger; 
        private readonly IMapper _mapper; 
        private readonly UserManager<User> _userManager; 
        private readonly IConfiguration _configuration;

        private User? _user;

        public AuthenticationService(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IConfiguration configuration)
        {
            _logger = logger;
            _mapper = mapper; 
            _userManager = userManager; 
            _configuration = configuration;
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
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET")); 
            var secret = new SymmetricSecurityKey(key); 
            
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims) 
        { 
            var jwtSettings = _configuration.GetSection("JwtSettings"); 
            
            var tokenOptions = new JwtSecurityToken
                (
                    issuer: jwtSettings["validIssuer"], 
                    audience: jwtSettings["validAudience"], 
                    claims: claims, 
                    expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["expires"])), 
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

            try
            {
                var result = await _userManager.CreateAsync(user, userForRegistration.Password);

                if (result.Succeeded)
                    await _userManager.AddToRolesAsync(user, userForRegistration.Roles);

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth)
        {
            _user = await _userManager.FindByNameAsync(userForAuth.UserName); 
            
            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, userForAuth.Password)); 
            
            if (!result) 
                _logger.LogWarn($"{nameof(ValidateUser)}: Authentication failed. Wrong user name or password."); 
            
            return result;
        }
    }
}