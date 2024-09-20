using Elasticsearch.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Threading.Tasks;
using WebApi.ActionFilters;
using WebApi.Entities.Exceptions;
using WebApi.Helpers;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Controllers
{
    [ApiController]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly IConfiguration _configuration;
        private readonly IEmailSenderService _emailSender;

        public AuthenticationController(IServiceManager service, IConfiguration configuration, IEmailSenderService emailSender)
        {
            _service = service;
            _configuration = configuration;
            _emailSender = emailSender;
        }

        [HttpGet("email")]
        [ApiVersion(version: VersionHelper.ApiVersion)]
        [ApiExplorerSettings(GroupName = "v1")]
        [Produces("application/json")]
        [AllowAnonymous]
        public async Task<IActionResult> VerifyEmail(string email)
        {
            var user = await _service.UserService.FindByEmailAsync(email, trackChanges: false);
            if (user is not null)
                return Ok(true);

            return Ok(false);
        }

        [HttpPost("register")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ApiVersion(version: VersionHelper.ApiVersion)]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] UserForRegistrationDto userForRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _service.AuthenticationService.RegisterUser(userForRegistration);
            if (!user.Succeeded)
            {
                List<string> errors = new List<string>();
                foreach (var error in user.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                    errors.Add(error.Code + ": " + error.Description);
                }
                return Ok(errors.ToArray());
            }

            return StatusCode(201);
        }

        [HttpGet("accountvalidationemail")]
        [ApiVersion(version: VersionHelper.ApiVersion)]
        [ApiExplorerSettings(GroupName = "v1")]
        [Produces("application/json")]
        [AllowAnonymous]
        public async Task AccountValidationEmail(string email)
        {
            var userEntity = await _service.UserService.FindByEmailAsync(email, trackChanges: false);
            if (userEntity is null)
                throw new UserNotFoundException(email);

            var user = await _service.UserService.MapToUser(userEntity);
            if (user is not null)
            {
                var token = await _service.AuthenticationService.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = $"https://localhost:8080/api/v1.1/authentication/confirmemail/?UserId={user.Id}&Token={token}";
                string args = $"Please confirm your account by <a href='{confirmationLink}'>clicking here to validate</a>;.";

                var content = await _emailSender.GetContent(EmailHelper.AccountValidation, user, args, trackChanges: false);
                if (content is null)
                    throw new EmailContentNotFound(EmailHelper.AccountValidation);

                await _emailSender.SendEmailAsync(user.Email, content);
            }
            else
                throw new AccountValidationEmailErrorException("Error on AccountValidationEmail method");
        }

        [HttpGet("confirmemail")]
        [ApiVersion(version: VersionHelper.ApiVersion)]
        [ApiExplorerSettings(GroupName = "v1")]
        [Produces("application/json")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await _service.UserService.GetUserAsync(Guid.Parse(userId), trackChanges: false);
            if (user is null || token is null)
                throw new UserNotFoundException("Link expired");
            else if (user is null)
                throw new UserNotFoundException("User not found");
            else
            {
                var result = await _service.UserService.ConfirmEmailAsync(user);
                if (result.Equals(true))
                {

                    return Redirect("http://localhost:5173/");
                }
                else
                    return Redirect("http://localhost:5173/error");
            }
        }

        [HttpPost("login")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ApiVersion(version: VersionHelper.ApiVersion)]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] UserForLoginAuthenticationDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IActionResult response = Unauthorized();
            if (!await _service.AuthenticationService.LoginUser(user))
                return StatusCode(401);

            var userData = await _service.UserService.FindUserByEmailAsync(user.Email, trackChanges: false);
            if (userData is null)
                throw new UserNotFoundException("User not found");

            var tokenString = await _service.AuthenticationService.GenerateToken(populateExp: true);
            response = Ok(new { user = userData, token = tokenString });

            return response;
        }


        [HttpPost("refresh")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ApiVersion(version: VersionHelper.ApiVersion)]
        [AllowAnonymous]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            var tokenDtoToReturn = await _service.AuthenticationService.RefreshToken(tokenDto);

            return Ok(tokenDtoToReturn);
        }
    }
}
