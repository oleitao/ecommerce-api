namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using WebApi.Entities.Models;
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
    public IActionResult GetAll()
    {
        try
        {
            var products = _service.ProductService.GetAllProducts(trackChanges: false);

            return Ok(products);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id:guid}", Name = "ProductById")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Product), StatusCodes.Status404NotFound)]
    public IActionResult GetById(Guid id)
    {
        var product = _service.ProductService.GetProduct(id, trackChanges: false);
        return Ok(product);
    }

    [HttpPost]
    [Consumes(typeof(ProductForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Create([FromBody] ProductForCreationDto product)
    {
        if (product is null)
            return BadRequest("ProductForCreationDto is null");

        var createdProduct = _service.ProductService.CreateProduct(product);

        return CreatedAtRoute("ProductById", new { id = createdProduct.Id }, createdProduct);
    }


    /*
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateProductRequest model)
        {
            _productService.Update(id, model);
            return Ok(new { message = "Product updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return Ok(new { message = "Product deleted" });
        }
        */
}