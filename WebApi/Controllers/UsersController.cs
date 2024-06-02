﻿namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi.Entities.Models;
using WebApi.Entities.RequestFeatures;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IServiceManager _service;

    public UsersController(
            IServiceManager service)
    {
        _service = service;
    }
    
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<User>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllUsers()
    {
        try
        {
            var users = await _service.UserService.GetAllUsersAsync(trackChanges: false);

            return Ok(users);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id:guid}", Name = "UserById")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(User), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByUserId(Guid id)
    {
        var user = await _service.UserService.GetUserAsync(id, trackChanges: false);
        return Ok(user);
    }

    [HttpGet(Name = "FilterUserMinAge")]
    [Route("filter/")]
    public async Task<IActionResult> FilterUserMinAge([FromQuery]UserParameters userParameters)
    {
        try
        {
            var result = await _service.UserService.GetAllUsersAsync(userParameters, trackChanges: false);

            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPost]
    [Consumes(typeof(UserForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateUser([FromBody] UserForCreationDto user)
    {
        if (user is null)
            return BadRequest("UserForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdUser = await _service.UserService.CreateUserAsync(user);

        return CreatedAtRoute("GetByUserId", new { id = createdUser.Id }, createdUser);
    }

    [HttpPut("{id:guid}")]
    [Consumes(typeof(UserForUpdateDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateUser(Guid id, UserForUpdateDto category)
    {
        if (category is null)
            return BadRequest("UserForUpdateDto object is null");

        await _service.UserService.UpdateUserAsync(id, category, trackChanges: true);
        
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        await _service.UserService.DeleteUserAsync(id, trackChanges: false);

        return NoContent();
    }
}