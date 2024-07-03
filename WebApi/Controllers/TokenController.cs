using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using WebApi.Service.Contracts;

namespace WebApi.Controllers
{
    [ApiController]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [Route("api/token/v{version:apiVersion}/[controller]")]
    public class TokenController : ControllerBase
    {
        private readonly IServiceManager _service;

        public TokenController(IServiceManager service)
        {
            _service = service;
        }
    }
}
