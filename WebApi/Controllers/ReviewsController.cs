namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

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
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Review>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        try
        {
            var reviews = _service.ReviewService.GetAllReviews(trackChanges: false);

            return Ok(reviews);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }


    [HttpGet("{id:guid}")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Review), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Review), StatusCodes.Status404NotFound)]
    public IActionResult GetById(Guid id)
    {
        var review = _service.ReviewService.GetReview(id, trackChanges: false);
        return Ok(review);
    }
/*
    [HttpPost]
    public IActionResult Create(CreateReviewRequest model)
    {
        _reviewService.Create(model);
        return Ok(new { message = "Category created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateReviewRequest model)
    {
        _reviewService.Update(id, model);
        return Ok(new { message = "Category updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _reviewService.Delete(id);
        return Ok(new { message = "Category deleted" });
    }
    */
}