namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Models.Products;
using WebApi.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController : ControllerBase
{
    private IProductService _productService;
    private IMapper _mapper;
    private ILoggerManager _logger;

    public ProductsController(
        IProductService productService,
        IMapper mapper,
        ILoggerManager logger)
    {
        _productService = productService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Entities.Product>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var products = _productService.GetAll();

        _logger.LogInfo("Here is info message from our values controller.");
        _logger.LogDebug("Here is debug message from our values controller.");
        _logger.LogWarn("Here is warn message from our values controller.");
        _logger.LogError("Here is an error message from our values controller.");

        return Ok(products);
    }

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
        return Ok(new { message = "Category created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateProductRequest model)
    {
        _productService.Update(id, model);
        return Ok(new { message = "Category updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _productService.Delete(id);
        return Ok(new { message = "Category deleted" });
    }
}