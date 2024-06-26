namespace WebApi.Controllers;

using Microsoft.AspNetCore.Authorization;
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
public class ShopAvatarsController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

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
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<ShopAvatar>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllShopAvatars()
    {
        List<ShopAvatar> shopAvaters = new List<ShopAvatar>();

        var key = $"{nameof(ShopAvatar)}";

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
            var result = JsonConvert.DeserializeObject<ShopAvatar>(item.Result);

            shopAvaters.Add(result);
        }

        return Ok(shopAvaters);
    }

    [HttpGet("{id:guid}", Name = "GetShopAvatarById")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ShopAvatar), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ShopAvatar), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetShopAvatarById(Guid id)
    {
        var key = $"{nameof(ShopAvatar)}";

        var shopAvatarsInCache = await _cache.GetStringAsync($"{key}:{id.ToString()}");
        if (shopAvatarsInCache is null)
        {
            var shopAvatarInDatabase = await _service.ShopAvatarService.GetShopAvatarAsync(id, trackChanges: false);

            string strValue = JsonConvert.SerializeObject(shopAvatarInDatabase);
            await _cache.SetAsync($"{key}:{shopAvatarInDatabase.Id}", Encoding.ASCII.GetBytes(strValue));

            return Ok(shopAvatarInDatabase);
        }

        var shopAvatar = JsonConvert.DeserializeObject<ShopAvatar>(shopAvatarsInCache);

        return Ok(shopAvatar);
    }

    [HttpPost]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(ShopAvatarForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateShopAvatar([FromBody] ShopAvatarForCreationDto shopAvatar)
    {
        var key = $"{nameof(ShopAvatar)}";

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
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    public async Task<IActionResult> UpdateShopAvatar(Guid id, ShopAvatarForUpdateDto shopAvatar)
    {
        if (shopAvatar is null)
            return BadRequest("ShopAvatarForUpdateDto object is null");

        await _service.ShopAvatarService.UpdateShopAvatar(id, shopAvatar, trackChanges: true);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> DeleteShopAvatar(Guid id)
    {
        var key = $"{nameof(ShopAvatar)}:{id.ToString()}";

        var shopAvatarInCache = await _cache.GetStringAsync(key);
        if (shopAvatarInCache is null)
        {
            await _service.ShopAvatarService.DeleteShopAvatarAsync(id, trackChanges: false);
        }
        else
        {
            await _cache.RemoveAsync(key);
            await _service.ShopAvatarService.DeleteShopAvatarAsync(id, trackChanges: false);
        }

        return NoContent();
    }
}