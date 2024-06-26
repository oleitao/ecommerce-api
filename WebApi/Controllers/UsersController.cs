namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Model;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApi.Helpers;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

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
    [ProducesResponseType(typeof(IEnumerable<User>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllUsers()
    {
        List<User> users = new List<User>();

        var key = $"{nameof(User)}";

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
            var result = JsonConvert.DeserializeObject<User>(item.Result);

            users.Add(result);
        }

        return Ok(users);
    }

    [HttpGet("{id:guid}", Name = "GetByUserId")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(User), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByUserId(Guid id)
    {
        var key = $"{nameof(User)}";

        var userInCache = await _cache.GetStringAsync($"{key}:{id.ToString()}");
        if (userInCache is null)
        {
            var userInDatabase = await _service.UserService.GetUserAsync(id, trackChanges: false);

            string strValue = JsonConvert.SerializeObject(userInDatabase);
            await _cache.SetAsync($"{key}:{userInDatabase.Id}", Encoding.ASCII.GetBytes(strValue));

            return Ok(userInDatabase);
        }

        var user = JsonConvert.DeserializeObject<User>(userInCache);

        return Ok(user);
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
    public async Task<IActionResult> CreateUser([FromBody] UserForCreationDto user)
    {
        var key = $"{nameof(User)}";

        if (user is null)
            return BadRequest("UserForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdUser = await _service.UserService.CreateUserAsync(user);

        CacheHelper.SetKey(createdUser, $"{key}:{createdUser.Id}", _cache);

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
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        var key = $"{nameof(User)}:{id.ToString()}";

        var userInCache = await _cache.GetStringAsync(key);
        if (userInCache is null)
        {
            await _service.UserService.DeleteUserAsync(id, trackChanges: false);
        }
        else
        {
            await _cache.RemoveAsync(key);
            await _service.UserService.DeleteUserAsync(id, trackChanges: false);
        }

        return NoContent();
    }
}