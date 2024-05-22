namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Users;
using WebApi.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ShopsController : ControllerBase
{
    private IShopService _shopService;
    private IMapper _mapper;

    public ShopsController(
        IShopService shopService,
        IMapper mapper)
    {
        _shopService = shopService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _shopService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _shopService.GetById(id);
        return Ok(user);
    }

    [HttpPost]
    public IActionResult Create(CreateShopRequest model)
    {
        _shopService.Create(model);
        return Ok(new { message = "Category created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateShopRequest model)
    {
        _shopService.Update(id, model);
        return Ok(new { message = "Category updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _shopService.Delete(id);
        return Ok(new { message = "Category deleted" });
    }
}