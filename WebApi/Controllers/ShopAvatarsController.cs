namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

[ApiController]
[Route("api/v1/[controller]")]
public class ShopAvatarsController : ControllerBase
{
    private readonly IServiceManager _service;

    public ShopAvatarsController(
        IServiceManager service)
    {
        _service = service;
    }

    
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<ShopAvatar>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        try
        {
            var shopAvatars = _service.ShopAvatarService.GetAllShopAvatars(trackChanges: false);

            return Ok(shopAvatars);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id:guid}")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ShopAvatar), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ShopAvatar), StatusCodes.Status404NotFound)]
    public IActionResult GetById(Guid id)
    {
        var shopAvatar = _service.ShopAvatarService.GetShopAvatar(id, trackChanges: false);
        return Ok(shopAvatar);
    }
 /*
    [HttpPost]
    public IActionResult Create(CreateShopAvatarRequest model)
    {
        _shopAvatarService.Create(model);
        return Ok(new { message = "ShopAvatar created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateShopAvatarRequest model)
    {
        _shopAvatarService.Update(id, model);
        return Ok(new { message = "ShopAvatar updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _shopAvatarService.Delete(id);
        return Ok(new { message = "ShopAvatar deleted" });
    }
    */
}