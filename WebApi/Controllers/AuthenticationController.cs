using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.ActionFilters;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;
        private IConfiguration _configuration;

        public AuthenticationController(IServiceManager service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }


        [HttpPost("register")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ApiVersion("1.1")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] UserForRegistrationDto userForRegistration)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _service.AuthenticationService.RegisterUser(userForRegistration);
            if (!user.Succeeded)
            { 
                foreach (var error in user.Errors) 
                { 
                    ModelState.TryAddModelError(error.Code, error.Description); 
                } 
                return BadRequest(ModelState); 
            }


            return StatusCode(201);
        }

        [HttpPost("login")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ApiVersion("1.1")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDto user) 
        {
            IActionResult response = Unauthorized();
            if (!await _service.AuthenticationService.LoginUser(user))
                return response; 

            var tokenString = await _service.AuthenticationService.CreateToken(populateExp: true);
            response = Ok(new { token = tokenString });

            return response; 
        }

        [HttpPost("refresh")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ApiVersion("1.1")]
        [AllowAnonymous]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            var tokenDtoToReturn = await _service.AuthenticationService.RefreshToken(tokenDto);

            return Ok(tokenDtoToReturn);
        }
    }
}
