using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApi.Service.Contracts;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/categories/{categoryId}/products")]
    public class CategoryProductsController : ControllerBase
    {
        private readonly IServiceManager _service;
        private IMapper _mapper;
        private LoggerManager _logger;

        public CategoryProductsController(
            IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetProductsByCategory(Guid categoryId)
        {
            var products = _service.ProductService.GetProductsByCategory(categoryId, trackChanges: false);
            return Ok(products);
        }
    }
}
