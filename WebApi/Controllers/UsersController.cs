﻿namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

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
    public IActionResult GetAll()
    {
        try
        {
            var users = _service.UserService.GetAllUsers(trackChanges: false);

            return Ok(users);
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
        var user = _userService.GetById(id);
        return Ok(user);
    }

    [HttpPost]
    public IActionResult Create(CreateUserRequest model)
    {
        _userService.Create(model);
        return Ok(new { message = "User created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateUserRequest model)
    {
        _userService.Update(id, model);
        return Ok(new { message = "User updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _userService.Delete(id);
        return Ok(new { message = "User deleted" });
    }
    */
}