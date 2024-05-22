namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Products;
using WebApi.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ProductsController : ControllerBase
{
    private IProductService _productService;
    private IMapper _mapper;

    public ProductsController(
        IProductService productService,
        IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _productService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _productService.GetById(id);
        return Ok(user);
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