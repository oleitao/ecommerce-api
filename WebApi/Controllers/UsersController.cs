namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v2")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<User>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _service.UserService.GetAllUsersAsync(trackChanges: false);

        return Ok(users);
    }

    [HttpGet("{id:guid}", Name = "GetByUserId")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v2")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(User), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByUserId(Guid id)
    {
        var user = await _service.UserService.GetUserAsync(id, trackChanges: false);
        return Ok(user);
    }

    /*
    [HttpGet(Name = "FilterUserMinAgeSort")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v2")]
    [Route("filter/")]
    public async Task<IActionResult> FilterUserMinAgeSort([FromQuery] UserParameters userParameters)
    {
        var result = await _service.UserService.GetAllUsersAsync(userParameters, trackChanges: false);

        return Ok(result);
    }
    */

    [HttpPost]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v2")]
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
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
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
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v2")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        await _service.UserService.DeleteUserAsync(id, trackChanges: false);

        return NoContent();
    }
}