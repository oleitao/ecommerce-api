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
public class ReviewsController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    const string key = $"{nameof(ReviewDto)}";

    public ReviewsController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
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
    [ApiExplorerSettings(GroupName ="v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<ReviewDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllReviews()
    {
        List<ReviewDto> reviews = new List<ReviewDto>();

        var reviewsInCache = CacheHelper.SearchAllKeys(_muxer, key);
        if (reviewsInCache is not null && reviewsInCache.Count <= 0)
        {
            var reviewsInDatabase = await _service.ReviewService.GetAllReviewsAsync(trackChanges: false);
            foreach (var category in reviewsInDatabase)
            {
                CacheHelper.SetKey(category, $"{key}:{category.Id}", _cache);
            }

            return Ok(reviewsInDatabase);
        }

        foreach (var review in reviewsInCache)
        {
            var item = _cache.GetStringAsync(review.ToString());
            var result = JsonConvert.DeserializeObject<ReviewDto>(item.Result);

            reviews.Add(result);
        }

        return Ok(reviews);
    }


    [HttpGet("{id:guid}", Name = "GetReviewByIdAsync")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ReviewDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ReviewDto), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetReviewById(Guid id)
    {
        var reviewInCache = await CacheHelper.GetKey<ReviewDto>(key, _cache);
        if (reviewInCache is null)
        {
            var reviewInDatabase = await _service.ReviewService.GetReviewAsync(id, trackChanges: false);
            if(reviewInDatabase is null)
                throw new ReviewNotFoundException(id);

            CacheHelper.SetKey<ReviewDto>(reviewInDatabase, $"{key}:{reviewInDatabase.Id}", _cache);

            return Ok(reviewInDatabase);
        }

        return Ok(reviewInCache);
    }

    [HttpPost]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(ReviewForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateReview([FromBody] ReviewForCreationDto review)
    {
        if (review is null)
            return BadRequest("ReviewForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdReview = await _service.ReviewService.CreateReviewAsync(review);

        CacheHelper.SetKey(createdReview, $"{key}:{createdReview.Id}", _cache);

        return CreatedAtRoute("GetReviewByIdAsync", new { id = createdReview.Id }, createdReview);
    }

    [HttpPut("{id:guid}")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> UpdateReview(Guid id, [FromBody]ReviewForUpdateDto reviewUpdate)
    {
        var key = $"{nameof(ReviewDto)}:{id.ToString()}";

        var review = await _service.ReviewService.GetReviewAsync(id, trackChanges: true);
        if (review is null)
            return BadRequest("ReviewDto object is null");

        if (reviewUpdate is null)
            return BadRequest("ReviewForUpdateDto object is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var reviewInCache = await CacheHelper.GetKey<ReviewDto>(key, _cache);
        if (reviewInCache is null)
        {
            await _service.ReviewService.UpdateReviewAsync(id, reviewUpdate, trackChanges: false);

            CacheHelper.SetKey<ReviewDto>(review, key, _cache);
        }
        else
        {
            await _service.ReviewService.UpdateReviewAsync(id, reviewUpdate, trackChanges: false);
            await _cache.RemoveAsync(key);

            var returnReview = await _service.ReviewService.GetReviewAsync(id, trackChanges: true);

            CacheHelper.SetKey<ReviewDto>(review, key, _cache);

            return Ok(returnReview);
        }

        return Ok(reviewInCache);
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> DeleteReview(Guid id)
    {
        var key = $"{nameof(ReviewDto)}:{id.ToString()}";

        var reviewInCache = await CacheHelper.GetKey<ReviewDto>(key, _cache);
        if (reviewInCache is null)
        {
            await _service.ReviewService.DeleteReviewAsync(id, trackChanges: false);
        }
        else
        {
            await _service.ReviewService.DeleteReviewAsync(id, trackChanges: false);
            await _cache.RemoveAsync(key);

            CacheHelper.SetKey<ReviewDto>(reviewInCache, key, _cache);
        }

        return NoContent();
    }
}