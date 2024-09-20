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
using System.Threading.Tasks;
using WebApi.Entities.Exceptions;
using WebApi.Helpers;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[ApiVersion(version: VersionHelper.ApiVersion)]
[Route("api/v{version:apiVersion}/[controller]")]
public class ImageUrlsController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    const string key = $"{nameof(ImageUrlDto)}";

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
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    //[Authorize]
    [ProducesResponseType(typeof(IEnumerable<ImageUrlDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllImageUrls()
    {
        List<ImageUrlDto> imageUrls = new List<ImageUrlDto>();

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
            var result = JsonConvert.DeserializeObject<ImageUrlDto>(item.Result);

            imageUrls.Add(result);
        }

        return Ok(imageUrls);
    }

    [HttpGet("{id:guid}", Name = "GetImageUrlById")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    //[Authorize]
    [ProducesResponseType(typeof(ImageUrlDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ImageUrlDto), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetImageUrlById(Guid id)
    {
        var imageUrlInCache = await CacheHelper.GetKey<ImageUrlDto>($"{key}:{id.ToString()}", _cache);
        if (imageUrlInCache is null)
        {
            var imageUrlInDatabase = await _service.ImageUrlService.GetImageUrlAsync(id, trackChanges: false);
            if (imageUrlInDatabase is null)
                throw new ImageUrlNotFoundException(id);

            CacheHelper.SetKey<ImageUrlDto>(imageUrlInDatabase, $"{key}:{imageUrlInDatabase.Id}", _cache);

            return Ok(imageUrlInDatabase);
        }

        return Ok(imageUrlInCache);
    }

    [HttpPost]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(ImageUrlForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateImageUrlAsync([FromBody] ImageUrlForCreationDto imageUrl)
    {
        if (imageUrl is null)
            return BadRequest("ImageUrlForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdImageUrl = await _service.ImageUrlService.CreateImageUrlAsync(imageUrl);

        CacheHelper.SetKey(createdImageUrl, $"{key}:{createdImageUrl.Id}", _cache);

        return CreatedAtRoute("GetImageUrlById", new { id = createdImageUrl.Id }, createdImageUrl);
    }

    [HttpPut("{id}")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> UpdateImageUrl(Guid id, ImageUrlForUpdateDto imageUrlUpdate)
    {
        var key = $"{nameof(ImageUrlDto)}:{id.ToString()}";

        var imageUrl = await _service.ImageUrlService.GetImageUrlAsync(id, trackChanges: true);
        if (imageUrl is null)
            return BadRequest("ImageUrlDto object is null");

        if (imageUrl is null)
            return BadRequest("ImageUrlForUpdateDto object is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var imageUrlInCache = await CacheHelper.GetKey<ImageUrlDto>(key, _cache);
        if (imageUrlInCache is null)
        {
            await _service.ImageUrlService.UpdateImageUrlAsync(id, imageUrlUpdate, trackChanges: true);

            CacheHelper.SetKey<ImageUrlDto>(imageUrl, key, _cache);
        }
        else
        {
            await _service.ImageUrlService.UpdateImageUrlAsync(id, imageUrlUpdate, trackChanges: true);
            await _cache.RemoveAsync(key);

            var returnImageUrl = await _service.ImageUrlService.GetImageUrlAsync(id, trackChanges: true);

            CacheHelper.SetKey<ImageUrlDto>(returnImageUrl, key, _cache);

            return Ok(returnImageUrl);
        }

        return Ok(imageUrlInCache);
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> DeleteImageUrl(Guid id)
    {
        var key = $"{nameof(ImageUrlDto)}:{id.ToString()}";

        var imageUrlInCache = await CacheHelper.GetKey<ImageUrlDto>(key, _cache);
        if (imageUrlInCache is null)
            await _service.ImageUrlService.DeleteImageUrlAsync(id, trackChanges: false);
        else
        {
            await _service.ImageUrlService.DeleteImageUrlAsync(id, trackChanges: false);
            await _cache.RemoveAsync(key);
        }

        return NoContent();
    }
}