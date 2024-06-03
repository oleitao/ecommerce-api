namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Entities.Models;
using WebApi.Entities.RequestFeatures;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IServiceManager _service;

    public ProductsController(
            IServiceManager service)
    {
        _service = service;
    }
    
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Product>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllProducts()
    {
        try
        {
            var products = await _service.ProductService.GetAllProductsAsync(trackChanges: false);

            return Ok(products);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Product>), StatusCodes.Status200OK)]
    [Route("filter/")]
    public async Task<IActionResult> FilterProductsSorted([FromQuery]ProductParameters productParameters)
    {
        try
        {
            var products = await _service.ProductService.FilterProductsSortedAsync(productParameters, trackChanges: false);

            return Ok(products);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id:guid}", Name = "GetProductById")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Product), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetProductById(Guid id)
    {
        var product = await _service.ProductService.GetProductAsync(id, trackChanges: false);
        return Ok(product);
    }

    [HttpPost]
    [Consumes(typeof(ProductForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateProduct([FromBody] ProductForCreationDto product)
    {
        if (product is null)
            return BadRequest("ProductForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdProduct = await _service.ProductService.CreateProductAsync(product);

        return CreatedAtRoute("GetProductById", new { id = createdProduct.Id }, createdProduct);
    }


    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateProduct(Guid id, ProductForUpdateDto product)
    {
        if (product is null)
            return BadRequest("ProductForUpdateDto object is null");

        await _service.ProductService.UpdateProductAsync(id, product, trackChanges: true);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(Guid id)
    {
        await _service.ProductService.DeleteProductAsync(id, trackChanges: false);

        return NoContent();
    }
}