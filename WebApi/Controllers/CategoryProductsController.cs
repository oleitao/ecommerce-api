﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/categories/{categoryId}/products")]
    public class CategoryProductsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CategoryProductsController(
            IServiceManager service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetProductsByCategory")]
        public async Task<IActionResult> GetProductsByCategory(Guid categoryId)
        {
            var products = await _service.ProductService.GetProductsByCategoryAsync(categoryId, trackChanges: false);

            return Ok(products);
        }

        [HttpPost]
        [Consumes(typeof(ProductForCreationDto), "application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<IActionResult> CreateProductForCategory(Guid categoryId, [FromBody] ProductForCreationDto product)
        {
            if (product is null)
                return BadRequest("ProductForCreationDto is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var productToReturn = await _service.ProductService.CreateProductForCategoryAsync(categoryId, product, trackChanges: false);
            
            return Ok(productToReturn);
        }

        [HttpPatch("{id:guid}")]
        public async Task<IActionResult> PartiallyUpdateProductForCompany(Guid categoryId, Guid Id, 
            [FromBody] JsonPatchDocument<ProductForUpdateDto> patchDoc)
        {
            if (patchDoc is null)
                return BadRequest("patchDoc object sent from client is null");

            var result = await _service.ProductService.GetProductForPatchAsync(categoryId, Id, catTrackChanges: false, prodTrackChanges: true);

            patchDoc.ApplyTo(result.productToPatch);

            await _service.ProductService.SaveChangesForPatchAsync(result.productToPatch, result.productEntity);

            return NoContent();
        }
    }
}
