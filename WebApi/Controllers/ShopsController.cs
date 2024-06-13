namespace WebApi.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Shop>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllShops()
    {
        try
        {
            var shops = await _service.ShopService.GetAllShopsAsync(trackChanges: false);

            return Ok(shops);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }


    [HttpGet("{id:guid}", Name = "GetShopById")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Shop), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Shop), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetShopById(Guid id)
    {
        var shop = await _service.ShopService.GetShopAsync(id, trackChanges: false);
        return Ok(shop);
    }

    [HttpPost]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
    [Consumes(typeof(ShopForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateShop([FromBody] ShopForCreationDto shop)
    {
        if (shop is null)
            return BadRequest("ShopForCreationDto is null");

        if(!ModelState.IsValid)
            return UnprocessableEntity(shop);

        var createdShop = await _service.ShopService.CreateShopAsync(shop);

        return CreatedAtRoute("GetShopById", new { id = createdShop.Id }, createdShop);
    }

    [HttpPut("{id:guid}")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
    public async Task<IActionResult> UpdateShop(Guid id, ShopForUpdateDto model)
    {
        if (model is null)
            return BadRequest("ShopForUpdateDto object is null");

        await _service.ShopService.UpdateShopAsync(id, model, trackChanges: true);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v2")]
    public async Task<IActionResult> DeleteShop(Guid id)
    {
        await _service.ShopService.DeleteShopAsync(id, trackChanges: false);

        return NoContent();
    }
}