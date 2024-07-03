namespace WebApi.Controllers;

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
[ApiVersion(version: VersionHelper.ApiVersion)]
[Route("api/v{version:apiVersion}/[controller]")]
public class ShopAvatarsController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    const string key = $"{nameof(ShopAvatarDto)}";

    public ShopAvatarsController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
    {
        _service = service;

        _client = client;
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("webApiCachingApp", "1.0"));
        _redis = muxer.GetDatabase();
        _cache = cache;
        _muxer = muxer;
    }


    [HttpGet]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<ShopAvatarDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllShopAvatars()
    {
        List<ShopAvatarDto> shopAvaters = new List<ShopAvatarDto>();

        var shopAvatarsInCache = CacheHelper.SearchAllKeys(_muxer, key);
        if (shopAvatarsInCache is not null && shopAvatarsInCache.Count <= 0)
        {
            var shopAvatarInDatabase = await _service.ShopAvatarService.GetAllShopAvatarsAsync(trackChanges: false);
            foreach (var shopAvatar in shopAvatarInDatabase)
            {
                CacheHelper.SetKey(shopAvatar, $"{key}:{shopAvatar.Id}", _cache);
            }

            return Ok(shopAvatarInDatabase);
        }

        foreach (var shopAvatar in shopAvatarsInCache)
        {
            var item = _cache.GetStringAsync(shopAvatar.ToString());
            var result = JsonConvert.DeserializeObject<ShopAvatarDto>(item.Result);

            shopAvaters.Add(result);
        }

        return Ok(shopAvaters);
    }

    [HttpGet("{id:guid}", Name = "GetShopAvatarById")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ShopAvatarDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ShopAvatarDto), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetShopAvatarById(Guid id)
    {
        var shopAvatarsInCache = await CacheHelper.GetKey<ShopAvatarDto>($"{key}:{id.ToString()}", _cache);
        if (shopAvatarsInCache is null)
        {
            var shopAvatarInDatabase = await _service.ShopAvatarService.GetShopAvatarAsync(id, trackChanges: false);
            if (shopAvatarInDatabase is null)
                throw new ShopAvatarNotFoundException(id);

            CacheHelper.SetKey<ShopAvatarDto>(shopAvatarInDatabase, $"{key}:{shopAvatarInDatabase.Id}", _cache);

            return Ok(shopAvatarInDatabase);
        }

        return Ok(shopAvatarsInCache);
    }

    [HttpPost]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(ShopAvatarForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateShopAvatar([FromBody] ShopAvatarForCreationDto shopAvatar)
    {
        if (shopAvatar is null)
            return BadRequest("ShopAvatarForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdShopAvatar = await _service.ShopAvatarService.CreateShopAvatarAsync(shopAvatar);

        CacheHelper.SetKey(createdShopAvatar, $"{key}:{createdShopAvatar.Id}", _cache);

        return CreatedAtRoute("GetShopAvatarById", new { id = createdShopAvatar.Id }, createdShopAvatar);
    }

    [HttpPut("{id:guid}")]
    //[Authorize]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    public async Task<IActionResult> UpdateShopAvatar(Guid id, ShopAvatarForUpdateDto shopAvatarUpdate)
    {
        var key = $"{nameof(ShopAvatarDto)}:{id.ToString()}";

        var shopAvatar = await _service.ShopAvatarService.GetShopAvatarAsync(id, trackChanges: true);
        if (shopAvatar is null)
            return BadRequest("ShopAvatarDto object is null");

        if (shopAvatarUpdate is null)
            return BadRequest("ShopAvatarForUpdateDto object is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var shopAvatarInCache = await CacheHelper.GetKey<ShopAvatarDto>(key, _cache);
        if (shopAvatarInCache is null)
        {
            await _service.ShopAvatarService.UpdateShopAvatar(id, shopAvatarUpdate, trackChanges: true);

            CacheHelper.SetKey<ShopAvatarDto>(shopAvatar, key, _cache);
        }
        else
        {
            await _service.ShopAvatarService.UpdateShopAvatar(id, shopAvatarUpdate, trackChanges: true);
            await _cache.RemoveAsync(key);

            var returnShopAvatar = await _service.ShopAvatarService.GetShopAvatarAsync(id, trackChanges: true);

            CacheHelper.SetKey<ShopAvatarDto>(returnShopAvatar, key, _cache);
        }

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> DeleteShopAvatar(Guid id)
    {
        var key = $"{nameof(ShopAvatarDto)}:{id.ToString()}";

        var shopAvatarInCache = await CacheHelper.GetKey<ShopAvatarDto>(key, _cache);
        if (shopAvatarInCache is null)
        {
            await _service.ShopAvatarService.DeleteShopAvatarAsync(id, trackChanges: false);
        }
        else
        {
            await _service.ShopAvatarService.DeleteShopAvatarAsync(id, trackChanges: false);
            await _cache.RemoveAsync(key);
        }

        return NoContent();
    }
}