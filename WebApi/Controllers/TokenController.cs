using Microsoft.AspNetCore.Mvc;
using WebApi.Service.Contracts;

namespace WebApi.Controllers
{
    [ApiController]
    [ApiVersion("1.1")]
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
