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
using System.Threading.Tasks;
using WebApi.Entities.Exceptions;
using WebApi.Entities.RequestFeatures;
using WebApi.Helpers;
using WebApi.ModelBinders;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[ApiVersion(version: VersionHelper.ApiVersion)]
[Route("api/v{version:apiVersion}/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    const string key = $"{nameof(CategoryDto)}";
    public CategoriesController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
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
    [ProducesResponseType(typeof(IEnumerable<Category>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllCategoriesAsync()
    {
        List<CategoryDto> categories = new List<CategoryDto>();

        var categoryInCache = CacheHelper.SearchAllKeys(_muxer, key);
        if (categoryInCache is not null && categoryInCache.Count <= 0)
        {
            var categoryInDatabase =  await _service.CategoryService.GetAllCategoriesAsync(trackChanges: false);
            foreach (var category in categoryInDatabase)
            {
                CacheHelper.SetKey(category, $"{key}:{category.Id}", _cache);
            }

            return Ok(categoryInDatabase);
        }

        foreach (var category in categoryInCache)
        {
            var item = _cache.GetStringAsync(category.ToString());
            var result = JsonConvert.DeserializeObject<CategoryDto>(item.Result);

            categories.Add(result);
        }

        return Ok(categories);
    }

    [HttpGet]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Category>), StatusCodes.Status200OK)]
    [Route("filter/")]
    //[Authorize]
    public async Task<IActionResult> GetAllCategoriesAsync([FromQuery] CategoryParameters categoryParameters)
    {
        List<CategoryDto> categories = new List<CategoryDto>();

        var categoryInCache = CacheHelper.SearchAllKeys(_muxer, key);
        if (categoryInCache is not null && categoryInCache.Count <= 0)
        {
            var categoryInDatabase = await _service.CategoryService.GetAllCategoriesAsync(trackChanges: false);
            foreach (var category in categoryInDatabase)
            {
                CacheHelper.SetKey(category, $"{key}:{category.Id}", _cache);
            }

            return Ok(categoryInDatabase);
        }

        foreach (var category in categoryInCache)
        {
            var item = _cache.GetStringAsync(category.ToString());
            var result = JsonConvert.DeserializeObject<CategoryDto>(item.Result);

            categories.Add(result);
        }

        return Ok(categories);
    }

    [HttpGet("{id:guid}", Name = "CategoryById")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(CategoryDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(CategoryDto), StatusCodes.Status404NotFound)]
    //[Authorize]
    public async Task<IActionResult> CategoryById(Guid id)
    {
        var categoryInCache = await CacheHelper.GetKey<CategoryDto>($"{key}:{id.ToString()}", _cache);
        if (categoryInCache is null)
        {
            var categoryInDatabase = await _service.CategoryService.GetCategoryAsync(id, trackChanges: false);
            if (categoryInDatabase is null)
                throw new CategoryNotFoundException(id);

            CacheHelper.SetKey(categoryInDatabase ,$"{key}:{categoryInDatabase.Id}", _cache);

            return Ok(categoryInDatabase);
        }

        return Ok(categoryInCache);
    }

    [HttpGet("collection/({ids})", Name = "CategoryCollection")]
    [Consumes(typeof(CategoryForCreationDto), "application/json")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
    public async Task<IActionResult> GetCategoryCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))]IEnumerable<Guid> ids)
    {
        var category = await _service.CategoryService.GetByIdsAsync(ids, trackChanges: false);

        return Ok(category);
    }

    [HttpOptions]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
    public IActionResult GetCategoriesOptions()
    {
        Response.Headers.Add("Allow", "GET, OPTIONS, POST");

        return Ok();
    }

    [HttpPost("collection")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
    public async Task<IActionResult> CreateCategoryCollection([FromBody] IEnumerable<CategoryForCreationDto> categoryCollection)
    {
        var resut = await _service.CategoryService.CreateCategoryCollectionAsync(categoryCollection);
        
        return CreatedAtRoute("GetCategoryCollection", new { resut.ids }, resut.categories);
    }

    [HttpPost]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(CategoryForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateCategory([FromBody] CategoryForCreationDto category)
    {
        if (category is null)
            return BadRequest("CategoryForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);


        var createdCategory = await _service.CategoryService.CreateCategoryAsync(category);

        CacheHelper.SetKey(createdCategory, $"{key}:{createdCategory.Id}", _cache);

        return CreatedAtRoute("CategoryById", new { id = createdCategory.Id }, createdCategory);
    }

    [HttpPut("{id:guid}")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Consumes(typeof(CategoryForUpdateDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    //[Authorize]
    public async Task<IActionResult> UpdateCategory(Guid id, [FromBody]CategoryForUpdateDto categoryUpdate)
    {
        var category = await _service.CategoryService.GetCategoryAsync(id, trackChanges: true);
        if (category is null)
            return BadRequest("CategoryDto object is null");

        if (categoryUpdate is null)
            return BadRequest("CategoryForUpdateDto object is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);


        var categoryInCache = await CacheHelper.GetKey<CategoryDto>($"{key}:{id.ToString()}", _cache);
        if (categoryInCache is null)
        {
            await _service.CategoryService.UpdateCategoryAsync(id, categoryUpdate, trackChanges: true);

            CacheHelper.SetKey<CategoryDto>(category, $"{key}:{id.ToString()}", _cache);
        }
        else
        {
            await _service.CategoryService.UpdateCategoryAsync(id, categoryUpdate, trackChanges: true);
            await _cache.RemoveAsync($"{key}:{id.ToString()}");

            var returnCategory = await _service.CategoryService.GetCategoryAsync(id, trackChanges: true);

            CacheHelper.SetKey<CategoryDto>(returnCategory, $"{key}:{id.ToString()}", _cache);

            return Ok(returnCategory);
        }

        return Ok(categoryInCache);
    }

    
    [HttpDelete("{id:guid}")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> DeleteCategory(Guid id)
    {
        var categoryInCache = await CacheHelper.GetKey<CategoryDto>($"{key}:{id.ToString()}", _cache);
        if (categoryInCache is null)
            await _service.CategoryService.DeleteCategoryAsync(id, trackChanges: false);
        else
        {            
            await _service.CategoryService.DeleteCategoryAsync(id, trackChanges: false);
            await _cache.RemoveAsync($"{key}:{id.ToString()}");
        }

        return NoContent();
    }
}