namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class ShopsController : ControllerBase
{
    private readonly IServiceManager _service;

    public ShopsController(
            IServiceManager service)
    {
        _service = service;
    }
    
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Shop>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        try
        {
            var shops = _service.ShopService.GetAllShops(trackChanges: false);

            return Ok(shops);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }


    [HttpGet("{id:guid}", Name = "ShopById")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Shop), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Shop), StatusCodes.Status404NotFound)]
    public IActionResult GetById(Guid id)
    {
        var shop = _service.ShopAvatarService.GetShopAvatar(id, trackChanges: false);
        return Ok(shop);
    }

    [HttpPost]
    [Consumes(typeof(ShopForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Create([FromBody] ShopForCreationDto shop)
    {
        if (shop is null)
            return BadRequest("ShopForCreationDto is null");

        var createdShop = _service.ShopService.CreateShop(shop);

        return CreatedAtRoute("ShopById", new { id = createdShop.Id }, createdShop);
    }
    /*
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateShopRequest model)
        {
            _shopService.Update(id, model);
            return Ok(new { message = "Shop updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _shopService.Delete(id);
            return Ok(new { message = "Shop deleted" });
        }
        */
}