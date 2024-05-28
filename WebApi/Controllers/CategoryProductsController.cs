using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;
using WebApi.Services;
using WebApi.Shared.DataTransferObjects;

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

        [HttpGet("{id:guid}", Name = "GetProductByCategory")]
        public IActionResult GetProductsByCategory(Guid categoryId)
        {
            var products = _service.ProductService.GetProductsByCategory(categoryId, trackChanges: false);

            return Ok(products);
        }

        [HttpPost]
        [Consumes(typeof(ProductForCreationDto), "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult CreateProductForCategory(Guid categoryId, [FromBody] ProductForCreationDto product)
        {
            if (product is null)
                return BadRequest("ProductForCreationDto is null");

            var productToReturn = _service.ProductService.CreateProductForCategory(categoryId, product, trackChanges: false);
            
            return Ok(productToReturn);
        }

        [HttpPatch("{id:guid}")]
        public IActionResult PartiallyUpdateProductForCompany(Guid categoryId, Guid Id, 
            [FromBody] JsonPatchDocument<ProductForUpdateDto> patchDoc)
        {
            if (patchDoc is null)
                return BadRequest("patchDoc object sent from client is null");

            var result = _service.ProductService.GetProductForPatch(categoryId, Id, catTrackChanges: false, prodTrackChanges: true);

            patchDoc.ApplyTo(result.productToPatch);

            _service.ProductService.SaveChangesForPatch(result.productToPatch, result.productEntity);

            return NoContent();
        }
    }
}
