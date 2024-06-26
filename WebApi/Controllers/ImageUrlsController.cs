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
using WebApi.Helpers;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class ImageUrlsController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    public ImageUrlsController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
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
    //[Authorize]
    [ProducesResponseType(typeof(IEnumerable<ImageUrl>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllImageUrls()
    {
        List<ImageUrl> imageUrls = new List<ImageUrl>();

        var key = $"{nameof(ImageUrl)}";

        var imageUrlsInCache = CacheHelper.SearchAllKeys(_muxer, key);
        if (imageUrlsInCache is not null && imageUrlsInCache.Count <= 0)
        {
            var imageUrlInDatabase = await _service.ImageUrlService.GetAllImageUrlsAsync(trackChanges: false);
            foreach (var category in imageUrlInDatabase)
            {
                CacheHelper.SetKey(category, $"{key}:{category.Id}", _cache);
            }

            return Ok(imageUrlInDatabase);
        }

        foreach (var imageUrl in imageUrlsInCache)
        {
            var item = _cache.GetStringAsync(imageUrl.ToString());
            var result = JsonConvert.DeserializeObject<ImageUrl>(item.Result);

            imageUrls.Add(result);
        }

        return Ok(imageUrls);
    }

    [HttpGet("{id:guid}", Name = "GetImageUrlById")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    //[Authorize]
    [ProducesResponseType(typeof(ImageUrl), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ImageUrl), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetImageUrlById(Guid id)
    {
        var key = $"{nameof(ImageUrl)}";

        var imageUrlInCache = await _cache.GetStringAsync($"{key}:{id.ToString()}");
        if (imageUrlInCache is null)
        {
            var imageUrlInDatabase = await _service.ImageUrlService.GetImageUrlAsync(id, trackChanges: false);

            string strValue = JsonConvert.SerializeObject(imageUrlInDatabase);
            await _cache.SetAsync($"{key}:{imageUrlInDatabase.Id}", Encoding.ASCII.GetBytes(strValue));

            return Ok(imageUrlInDatabase);
        }

        var imageUrl = JsonConvert.DeserializeObject<ImageUrl>(imageUrlInCache);

        return Ok(imageUrl);
    }

    [HttpPost]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(ImageUrlForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateImageUrlAsync([FromBody] ImageUrlForCreationDto imageUrl)
    {
        var key = $"{nameof(ImageUrl)}";

        if (imageUrl is null)
            return BadRequest("ImageUrlForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdImageUrl = await _service.ImageUrlService.CreateImageUrlAsync(imageUrl);

        CacheHelper.SetKey(createdImageUrl, $"{key}:{createdImageUrl.Id}", _cache);

        return CreatedAtRoute("GetImageUrlById", new { id = createdImageUrl.Id }, createdImageUrl);
    }

    [HttpPut("{id}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> UpdateImageUrl(Guid id, ImageUrlForUpdateDto imageUrl)
    {
        if (imageUrl is null)
            return BadRequest("ImageUrlForUpdateDto object is null");

        await _service.ImageUrlService.UpdateImageUrlAsync(id, imageUrl, trackChanges: true);
        
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> DeleteImageUrl(Guid id)
    {
        var key = $"{nameof(ImageUrl)}:{id.ToString()}";

        var imageUrlInCache = await _cache.GetStringAsync(key);
        if (imageUrlInCache is null)
            await _service.ImageUrlService.DeleteImageUrlAsync(id, trackChanges: false);
        else
        {
            await _cache.RemoveAsync(key);
            await _service.ImageUrlService.DeleteImageUrlAsync(id, trackChanges: false);
        }

        return NoContent();
    }
}