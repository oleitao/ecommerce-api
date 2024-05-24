namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

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

    /*
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = _productService.GetById(id);
        return Ok(product);
    }

    [HttpPost]
    public IActionResult Create(CreateProductRequest model)
    {
        _productService.Create(model);
        return Ok(new { message = "Product created" });
    }

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