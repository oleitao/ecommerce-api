namespace WebApi.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using WebApi.Entities.Exceptions;
using WebApi.Helpers;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class ShopsController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    public ShopsController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
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
    [ProducesResponseType(typeof(IEnumerable<Shop>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllShops()
    {
        List<Shop> shops = new List<Shop>();

        var key = $"{nameof(Shop)}";

        var shopsInCache = CacheHelper.SearchAllKeys(_muxer, key);
        if (shopsInCache is not null && shopsInCache.Count <= 0)
        {
            var shopsInDatabase = await _service.ShopService.GetAllShopsAsync(trackChanges: false);
            foreach (var shop in shopsInDatabase)
            {
                CacheHelper.SetKey(shop, $"{key}:{shop.Id}", _cache);
            }

            return Ok(shopsInDatabase);
        }

        foreach (var shop in shopsInCache)
        {
            var item = _cache.GetStringAsync(shop.ToString());
            var result = JsonConvert.DeserializeObject<Shop>(item.Result);

            shops.Add(result);
        }

        return Ok(shops);
    }


    [HttpGet("{id:guid}", Name = "GetShopById")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Shop), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Shop), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetShopById(Guid id)
    {
        var key = $"{nameof(Shop)}";

        var shopInCache = await _cache.GetStringAsync($"{key}:{id.ToString()}");
        if (shopInCache is null)
        {
            var shopInDatabase = await _service.ShopService.GetShopAsync(id, trackChanges: false);
            if (shopInDatabase is null)
                throw new ShopNotFoundException(id);

            string strValue = JsonConvert.SerializeObject(shopInDatabase);
            await _cache.SetAsync($"{key}:{shopInDatabase.Id}", Encoding.ASCII.GetBytes(strValue));

            return Ok(shopInDatabase);
        }

        var shop = JsonConvert.DeserializeObject<Shop>(shopInCache);

        return Ok(shop);
    }

    [HttpPost]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(ShopForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateShop([FromBody] ShopForCreationDto shop)
    {
        var key = $"{nameof(Shop)}";

        if (shop is null)
            return BadRequest("ShopForCreationDto is null");

        if(!ModelState.IsValid)
            return UnprocessableEntity(shop);

        var createdShop = await _service.ShopService.CreateShopAsync(shop);

        CacheHelper.SetKey(createdShop, $"{key}:{createdShop.Id}", _cache);

        return CreatedAtRoute("GetShopById", new { id = createdShop.Id }, createdShop);
    }

    [HttpPut("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> UpdateShop(Guid id, ShopForUpdateDto shop)
    {
        if (shop is null)
            return BadRequest("ShopForUpdateDto object is null");

        await _service.ShopService.UpdateShopAsync(id, shop, trackChanges: true);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> DeleteShop(Guid id)
    {
        var shop = await _service.ShopService.GetShopAsync(id, trackChanges: false);
        if (shop is null)
            throw new ShopAvatarNotFoundException(id);       

        //remove product
        var key = $"{nameof(Product)}:{id.ToString()}";
        var productInCache = await _cache.GetStringAsync(key);
        if (productInCache is null)
            await _service.ProductService.DeleteProductByShopAsync(id);
        else
        {
            await _cache.RemoveAsync(key);
            await _service.ProductService.DeleteProductByShopAsync(id);
        }

        //remove shop_avatar
        key = $"{nameof(ShopAvatar)}:{id.ToString()}";
        var shopAvatarInCache = await _cache.GetStringAsync(key);
        if (shopAvatarInCache is null)
            await _service.ShopAvatarService.DeleteShopAvatarAsync(shop.ShopAvatarId, trackChanges: false);
        else
        {
            await _cache.RemoveAsync(key);
            await _service.ShopAvatarService.DeleteShopAvatarAsync(shop.ShopAvatarId, trackChanges: false);
        }

        //remove shop
        key = $"{nameof(Shop)}:{id.ToString()}";
        var shopInCache = await _cache.GetStringAsync(key);
        if (shopInCache is null)
            await _service.ShopService.DeleteShopAsync(id, trackChanges: false);
        else
        {
            await _cache.RemoveAsync(key);
            await _service.ShopService.DeleteShopAsync(id, trackChanges: false);
        }

        return NoContent();
    }
}