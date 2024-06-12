namespace WebApi.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class ReviewsController : ControllerBase
{
    private readonly IServiceManager _service;

    public ReviewsController(
        IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName ="v1")]
    [Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Review>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllReviews()
    {
        try
        {
            var reviews = await _service.ReviewService.GetAllReviewsAsync(trackChanges: false);

            return Ok(reviews);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }


    [HttpGet("{id:guid}", Name = "GetReviewById")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v2")]
    [Authorize]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Review), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Review), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetReviewById(Guid id)
    {
        var review = await _service.ReviewService.GetReviewAsync(id, trackChanges: false);
        return Ok(review);
    }

    [HttpPost]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
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

        return CreatedAtRoute("GetReviewById", new { id = createdReview.Id }, createdReview);
    }

    [HttpPut("{id:guid}")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Authorize]
    public async Task<IActionResult> UpdateReview(Guid id, [FromBody]ReviewForUpdateDto review)
    {
        if (review is null)
            return BadRequest("ReviewForUpdateDto object is null");

        await _service.ReviewService.UpdateReviewAsync(id, review, trackChanges: false);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v2")]
    public async Task<IActionResult> DeleteReview(Guid id)
    {
        await _service.ReviewService.DeleteReviewAsync(id, trackChanges: false);

        return NoContent();
    }
}