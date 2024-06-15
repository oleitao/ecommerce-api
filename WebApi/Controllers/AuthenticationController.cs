using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public AuthenticationController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        [ApiExplorerSettings(GroupName = "v1")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<User>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var categories = await _service.UserService.GetAllUsersAsync(trackChanges: false);

                return Ok(categories);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpPost]
        [ApiExplorerSettings(GroupName = "v1")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var result = await _service.AuthenticationService.RegisterUser(userForRegistration); 
            
            if (!result.Succeeded)
            { 
                foreach (var error in result.Errors) 
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
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user) 
        { 
            if (!await _service.AuthenticationService.ValidateUser(user)) 
                return Unauthorized(); 

            var tokenDto = await _service.AuthenticationService.CreateToken(populateExp: true);
            
            return Ok(tokenDto); 
        }

        [HttpPost("refresh")]
        [ApiExplorerSettings(GroupName = "v1")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            var tokenDtoToReturn = await _service.AuthenticationService.RefreshToken(tokenDto);

            return Ok(tokenDtoToReturn);
        }
    }
}
