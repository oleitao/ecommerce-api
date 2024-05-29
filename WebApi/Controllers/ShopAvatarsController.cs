﻿namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

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
    public async Task<IActionResult> GetAllShopAvatars()
    {
        try
        {
            var shopAvatars = await _service.ShopAvatarService.GetAllShopAvatarsAsync(trackChanges: false);

            return Ok(shopAvatars);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id:guid}", Name = "GetShopAvatarById")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ShopAvatar), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ShopAvatar), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetShopAvatarById(Guid id)
    {
        var shopAvatar = await _service.ShopAvatarService.GetShopAvatarAsync(id, trackChanges: false);
        return Ok(shopAvatar);
    }

    [HttpPost]
    [Consumes(typeof(ShopAvatarForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateShoAvatar([FromBody] ShopAvatarForCreationDto shopAvatar)
    {
        if (shopAvatar is null)
            return BadRequest("ShopAvatarForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdShopAvatar = await _service.ShopAvatarService.CreateShopAvatarAsync(shopAvatar);

        return CreatedAtRoute("GetShopAvatarById", new { id = createdShopAvatar.Id }, createdShopAvatar);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateShopAvatar(Guid id, ShopAvatarForUpdateDto shopAvatar)
    {
        if (shopAvatar is null)
            return BadRequest("ShopAvatarForUpdateDto object is null");

        await _service.ShopAvatarService.UpdateShopAvatar(id, shopAvatar, trackChanges: true);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteShopAvatar(Guid id)
    {
        await _service.ShopAvatarService.DeleteShopAvatar(id, trackChanges: false);

        return NoContent();
    }
}