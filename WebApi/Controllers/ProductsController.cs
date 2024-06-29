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
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[ApiVersion("1.1")]
[Route("api/v{version:apiVersion}/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    const string key = $"{nameof(ProductDto)}";

    public ProductsController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
    {
        _service = service;

        _client = client;
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("webApiCachingApp", "1.0"));
        _redis = muxer.GetDatabase();
        _cache = cache;
        _muxer = muxer;
    }

    [HttpGet]
    [HttpHead]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllProducts()
    {
        List<ProductDto> products = new List<ProductDto>();

        var productsInCache = CacheHelper.SearchAllKeys(_muxer, key);
        if (productsInCache is not null && productsInCache.Count <= 0)
        {
            var productsInDatabase = await _service.ProductService.GetAllProductsAsync(trackChanges: false);
            foreach (var product in productsInDatabase)
            {
                CacheHelper.SetKey(product, $"{key}:{product.Id}", _cache);
            }

            return Ok(productsInDatabase);
        }

        foreach (var product in productsInCache)
        {
            var item = _cache.GetStringAsync(product.ToString());
            var result = JsonConvert.DeserializeObject<ProductDto>(item.Result);

            products.Add(result);
        }

        return Ok(products);
    }

    [HttpGet]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Product>), StatusCodes.Status200OK)]
    [Route("filter/")]
    public async Task<IActionResult> FilterProductsSorted([FromQuery]ProductParameters productParameters)
    {
        try
        {
            var products = await _service.ProductService.FilterProductsSortedAsync(productParameters, trackChanges: false);

            return Ok(products);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet("{id:guid}", Name = "GetProductById")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ProductDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProductDto), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetProductById(Guid id)
    {
        var productsInCache = await CacheHelper.GetKey<ProductDto>($"{key}:{id.ToString()}", _cache);
        if (productsInCache is null)
        {
            var productsInDatabase = await _service.ProductService.GetProductAsync(id, trackChanges: false);
            if (productsInDatabase is null)
                throw new ProductNotFoundException(id);

            CacheHelper.SetKey<ProductDto>(productsInDatabase, $"{key}:{productsInDatabase.Id}", _cache);

            return Ok(productsInDatabase);
        }

        return Ok(productsInCache);
    }

    [HttpPost]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(ProductForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateProduct([FromBody] ProductForCreationDto product)
    {
        if (product is null)
            return BadRequest("ProductForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdProduct = await _service.ProductService.CreateProductAsync(product);

        CacheHelper.SetKey(createdProduct, $"{key}:{createdProduct.Id}", _cache);

        return CreatedAtRoute("GetProductById", new { id = createdProduct.Id }, createdProduct);
    }


    [HttpPut("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> UpdateProduct(Guid id, ProductForUpdateDto productUpdate)
    {
        var key = $"{nameof(ProductDto)}:{id.ToString()}";

        var product = await _service.ProductService.GetProductAsync(id, trackChanges: true);
        if (product is null)
            return BadRequest("ProductDto object is null");

        var category = await _service.CategoryService.GetCategoryAsync(product.CategoryId, trackChanges: false);
        if (category is null)
            throw new CategoryNotFoundException(product.CategoryId);

        var shop = await _service.ShopService.GetShopAsync(product.ShopId, trackChanges: false);
        if(shop is null)
            throw new ShopNotFoundException(product.ShopId);

        if (productUpdate is null)
            return BadRequest("ProductForUpdateDto object is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var productInCache = await CacheHelper.GetKey<ProductDto>(key, _cache);
        if (productInCache is null)
        {
            await _service.ProductService.UpdateProductAsync(id, productUpdate, trackChanges: true);

            CacheHelper.SetKey<ProductDto>(product, key, _cache);
        }
        else
        {
            await _service.ProductService.UpdateProductAsync(id, productUpdate, trackChanges: true);
            await _cache.RemoveAsync(key);

            var returnProduct = await _service.ProductService.GetProductAsync(id, trackChanges: true);

            CacheHelper.SetKey<ProductDto>(returnProduct, key, _cache);
        }

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    public async Task<IActionResult> DeleteProduct(Guid id)
    {
        //remove image_url by productUpdate ID
        var key = $"{nameof(ImageUrlDto)}:{id.ToString()}";
        var imageUrlInCache = await _cache.GetStringAsync(key);
        if (imageUrlInCache is null)
            await _service.ImageUrlService.DeleteImageUrlByProductIdAsync(id, trackChanges: false);
        else
        {
            await _service.ImageUrlService.DeleteImageUrlByProductIdAsync(id, trackChanges: false);
            await _cache.RemoveAsync(key);
        }

        //remove review by productUpdate ID
        key = $"{nameof(ReviewDto)}:{id.ToString()}";
        var reviewInCache = await _cache.GetStringAsync(key);
        if (reviewInCache is null)
            await _service.ReviewService.DeleteReviewByProductIdAsync(id, trackChanges: false);
        else
        {
            await _service.ReviewService.DeleteReviewByProductIdAsync(id, trackChanges: false);
            await _cache.RemoveAsync(key);
        }

        //remove shop by productUpdate ID
        key = $"{nameof(ShopDto)}:{id.ToString()}";
        var shopInCache = await _cache.GetStringAsync(key);
        if (shopInCache is null)
            await _service.ShopService.DeleteShopByProductIdAsync(id, trackChanges: false);
        else
        {
            await _service.ShopService.DeleteShopByProductIdAsync(id, trackChanges: false);
            await _cache.RemoveAsync(key);
        }

        //remove productUpdate by productUpdate ID
        key = $"{nameof(ProductDto)}:{id.ToString()}";
        var productInCache = await _cache.GetStringAsync(key);
        if (productInCache is null)
            await _service.ProductService.DeleteProductAsync(id, trackChanges: false);
        else
        {
            await _service.ProductService.DeleteProductAsync(id, trackChanges: false);
            await _cache.RemoveAsync(key);
        }

        return NoContent();
    }
}