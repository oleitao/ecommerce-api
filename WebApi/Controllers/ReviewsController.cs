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
using WebApi.Entities.Exceptions;
using WebApi.Helpers;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class ReviewsController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

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
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName ="v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Review>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllReviews()
    {
        List<Review> reviews = new List<Review>();

        var key = $"{nameof(Review)}";

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
            var result = JsonConvert.DeserializeObject<Review>(item.Result);

            reviews.Add(result);
        }

        return Ok(reviews);
    }


    [HttpGet("{id:guid}", Name = "GetReviewByIdAsync")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Review), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Review), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetReviewById(Guid id)
    {
        var key = $"{nameof(Review)}";

        var reviewInCache = await _cache.GetStringAsync($"{key}:{id.ToString()}");
        if (reviewInCache is null)
        {
            var reviewInDatabase = await _service.ReviewService.GetReviewAsync(id, trackChanges: false);
            if(reviewInDatabase is null)
                throw new ReviewNotFoundException(id);

            string strValue = JsonConvert.SerializeObject(reviewInDatabase);
            await _cache.SetAsync($"{key}:{reviewInDatabase.Id}", Encoding.ASCII.GetBytes(strValue));

            return Ok(reviewInDatabase);
        }

        var review = JsonConvert.DeserializeObject<Review>(reviewInCache);

        return Ok(review);
    }

    [HttpPost]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    [Consumes(typeof(ReviewForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateReview([FromBody] ReviewForCreationDto review)
    {
        var key = $"{nameof(Review)}";

        if (review is null)
            return BadRequest("ReviewForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdReview = await _service.ReviewService.CreateReviewAsync(review);

        CacheHelper.SetKey(createdReview, $"{key}:{createdReview.Id}", _cache);

        return CreatedAtRoute("GetReviewByIdAsync", new { id = createdReview.Id }, createdReview);
    }

    [HttpPut("{id:guid}")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> UpdateReview(Guid id, [FromBody]ReviewForUpdateDto review)
    {
        if (review is null)
            return BadRequest("ReviewForUpdateDto object is null");

        await _service.ReviewService.UpdateReviewAsync(id, review, trackChanges: false);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion("1.1")]
    [ApiExplorerSettings(GroupName = "v1")]
    //[Authorize]
    public async Task<IActionResult> DeleteReview(Guid id)
    {
        var key = $"{nameof(Review)}:{id.ToString()}";

        var reviewInCache = await _cache.GetStringAsync(key);
        if (reviewInCache is null)
        {
            await _service.ReviewService.DeleteReviewAsync(id, trackChanges: false);
        }
        else
        {
            await _cache.RemoveAsync(key);
            await _service.ReviewService.DeleteReviewAsync(id, trackChanges: false);
        }

        return NoContent();
    }
}