namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Users;
using WebApi.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ShopAvatarsController : ControllerBase
{
    private IShopAvatarService _shopAvatarService;
    private IMapper _mapper;

    public ShopAvatarsController(
        IShopAvatarService shopAvatarService,
        IMapper mapper)
    {
        _shopAvatarService = shopAvatarService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _shopAvatarService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _shopAvatarService.GetById(id);
        return Ok(user);
    }

    [HttpPost]
    public IActionResult Create(CreateShopAvatarRequest model)
    {
        _shopAvatarService.Create(model);
        return Ok(new { message = "Category created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateShopAvatarRequest model)
    {
        _shopAvatarService.Update(id, model);
        return Ok(new { message = "Category updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _shopAvatarService.Delete(id);
        return Ok(new { message = "Category deleted" });
    }
}