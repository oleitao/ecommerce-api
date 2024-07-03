using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WebApi.ActionFilters;
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
        private IConfiguration _configuration;

        public AuthenticationController(IServiceManager service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }


        [HttpPost("register")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ApiVersion(version: VersionHelper.ApiVersion)]
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
        [ApiVersion(version: VersionHelper.ApiVersion)]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDto user) 
        {
            IActionResult response = Unauthorized();
            if (!await _service.AuthenticationService.LoginUser(user))
                return response; 

            var tokenString = await _service.AuthenticationService.GenerateToken(populateExp: true);
            response = Ok(new { token = tokenString });

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
