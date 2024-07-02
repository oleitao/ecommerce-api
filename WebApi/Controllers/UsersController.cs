namespace WebApi.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApi.Entities.Exceptions;
using WebApi.Helpers;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[ApiVersion("1.1")]
[Route("api/v{version:apiVersion}/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    const string key = $"{nameof(UserDto)}";

    public UsersController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
    {
        _service = service;

        _client = client;
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("webApiCachingApp", "1.0"));
        _redis = muxer.GetDatabase();
        _cache = cache;
        _muxer = muxer;
    }


    [HttpGet]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<UserDto>), StatusCodes.Status200OK)]
    [Authorize(Roles = "Administrator")]
    [Authorize(Roles = "Manager")]
    public async Task<IActionResult> GetAllUsers()
    {
        List<UserDto> users = new List<UserDto>();

        var usersInCache = CacheHelper.SearchAllKeys(_muxer, key);
        if (usersInCache is not null && usersInCache.Count <= 0)
        {
            var usersInDatabase = await _service.UserService.GetAllUsersAsync(trackChanges: false);
            foreach (var user in usersInDatabase)
            {
                CacheHelper.SetKey(user, $"{key}:{user.Id}", _cache);
            }

            return Ok(usersInDatabase);
        }

        foreach (var user in usersInCache)
        {
            var item = _cache.GetStringAsync(user.ToString());
            var result = JsonConvert.DeserializeObject<UserDto>(item.Result);

            users.Add(result);
        }

        return Ok(users);
    }

    [HttpGet("{id:guid}", Name = "GetByUserId")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByUserId(Guid id)
    {
        var userInCache = await CacheHelper.GetKey<UserDto>($"{key}:{id.ToString()}", _cache);        
        if (userInCache is null)
        {
            var userInDatabase = await _service.UserService.GetUserAsync(id, trackChanges: false);
            if (userInDatabase is null)
                throw new UserNotFoundException(id);

            CacheHelper.SetKey<UserDto>(userInDatabase, $"{key}:{userInDatabase.Id}", _cache);

            return Ok(userInDatabase);
        }

        return Ok(userInCache);
    }

    /*
    [HttpGet(Name = "FilterUserMinAgeSort")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("filter/")]
    public async Task<IActionResult> FilterUserMinAgeSort([FromQuery] UserParameters userParameters)
    {
        var result = await _service.UserService.GetAllUsersAsync(userParameters, trackChanges: false);

        return Ok(result);
    }
    */

    [HttpPost]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Consumes(typeof(UserForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [Authorize(Roles = "Administrator")]
    [Authorize(Roles = "Manager")]
    [Authorize(Roles = "User")]
    public async Task<IActionResult> CreateUser([FromBody] UserForCreationDto user)
    {
        if (user is null)
            return BadRequest("UserForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdUser = await _service.UserService.CreateUserAsync(user);

        CacheHelper.SetKey(createdUser, $"{key}:{createdUser.Id}", _cache);

        return CreatedAtRoute("GetByUserId", new { id = createdUser.Id }, createdUser);
    }

    [HttpPut("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Consumes(typeof(UserForUpdateDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Authorize(Roles = "Administrator")]
    [Authorize(Roles = "Manager")]
    [Authorize(Roles = "User")]
    public async Task<IActionResult> UpdateUser(Guid id, UserForUpdateDto userUpdate)
    {
        var key = $"{nameof(UserDto)}:{id.ToString()}";

        var user = await _service.UserService.GetUserAsync(id, trackChanges: true);
        if (user is null)
            return BadRequest("UserDto object is null");

        if (userUpdate is null)
            return BadRequest("UserForUpdateDto object is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var userInCache = await CacheHelper.GetKey<UserDto>(key, _cache);
        if (userInCache is null)
        {
            await _service.UserService.UpdateUserAsync(id, userUpdate, trackChanges: true);

            CacheHelper.SetKey<UserDto>(user, key, _cache);
        }
        else
        {
            await _service.UserService.UpdateUserAsync(id, userUpdate, trackChanges: true);
            await _cache.RemoveAsync(key);

            var returnUser = await _service.UserService.GetUserAsync(id, trackChanges: true);

            CacheHelper.SetKey<UserDto>(returnUser, key, _cache);
        }        
        
        return NoContent();
    }

    [HttpDelete("{id}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize(Roles = "Administrator")]
    [Authorize(Roles = "Manager")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        var key = $"{nameof(UserDto)}:{id.ToString()}";

        var userInCache = await CacheHelper.GetKey<UserDto>(key, _cache);
        if (userInCache is null)
        {
            await _service.UserService.DeleteUserAsync(id, trackChanges: false);
        }
        else
        {
            await _service.UserService.DeleteUserAsync(id, trackChanges: false);            
            await _cache.RemoveAsync(key);            
        }

        return NoContent();
    }
}