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
using WebApi.Entities.Exceptions;
using WebApi.Entities.RequestFeatures;
using WebApi.Helpers;
using WebApi.ModelBinders;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;
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
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    //[Authorize]
    [ProducesResponseType(typeof(IEnumerable<Category>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllCategoriesAsync()
    {
        List<Category> categories = new List<Category>();

        var key = $"{nameof(Category)}";

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
            var result = JsonConvert.DeserializeObject<Category>(item.Result);

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
        List<Category> categories = new List<Category>();

        var key = $"{nameof(Category)}";

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
            var result = JsonConvert.DeserializeObject<Category>(item.Result);

            categories.Add(result);
        }

        return Ok(categories);
    }

    [HttpGet("{id:guid}", Name = "CategoryById")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Category), StatusCodes.Status404NotFound)]
    //[Authorize]
    public async Task<IActionResult> CategoryById(Guid id)
    {
        var key = $"{nameof(Category)}";

        var categoryInCache = await _cache.GetStringAsync($"{key}:{id.ToString()}");
        if (categoryInCache is null)
        {
            var categoryInDatabase = await _service.CategoryService.GetCategoryAsync(id, trackChanges: false);
            if (categoryInDatabase is null)
                throw new CategoryNotFoundException(id);

            string strValue = JsonConvert.SerializeObject(categoryInDatabase);
            await _cache.SetAsync($"{key}:{categoryInDatabase.Id}", Encoding.ASCII.GetBytes(strValue));

            return Ok(categoryInDatabase);
        }

        var category = JsonConvert.DeserializeObject<Category>(categoryInCache);

        return Ok(category);
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
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(CategoryForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateCategory([FromBody] CategoryForCreationDto category)
    {
        var key = $"{nameof(Category)}";

        if (category is null)
            return BadRequest("CategoryForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);


        var createdCategory = await _service.CategoryService.CreateCategoryAsync(category);

        CacheHelper.SetKey(createdCategory, $"{key}:{createdCategory.Id}", _cache);

        return CreatedAtRoute("CategoryById", new { id = createdCategory.Id }, createdCategory);
    }

    [HttpPut("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Consumes(typeof(CategoryForUpdateDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    //[Authorize]
    public async Task<IActionResult> UpdateCategory(Guid id, [FromBody]CategoryForUpdateDto categry)
    {
        if (categry is null)
            return BadRequest("CategoryForUpdateDto object is null");

        await _service.CategoryService.UpdateCategoryAsync(id, categry, trackChanges: true);
        
        return NoContent();
    }

    
    [HttpDelete("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> DeleteCategory(Guid id)
    {
        var key = $"{nameof(Category)}:{id.ToString()}";

        var categoryInCache = await _cache.GetStringAsync(key);
        if (categoryInCache is null)
            await _service.CategoryService.DeleteCategoryAsync(id, trackChanges: false);
        else
        {
            await _cache.RemoveAsync(key);
            await _service.CategoryService.DeleteCategoryAsync(id, trackChanges: false);            
        }

        return NoContent();
    }
}