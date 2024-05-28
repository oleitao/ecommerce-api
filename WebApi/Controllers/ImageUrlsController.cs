namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class ImageUrlsController : ControllerBase
{
    private readonly IServiceManager _service;

    public ImageUrlsController(
            IServiceManager service)
    {
        _service = service;
    }

    
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<ImageUrl>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var imageUrls = _service.ImageUrlService.GetAllImageUrls(trackChanges: false);

        return Ok(imageUrls);
    }

    [HttpGet("{id:guid}", Name = "ImageUrlById")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ImageUrl), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ImageUrl), StatusCodes.Status404NotFound)]
    public IActionResult GetById(Guid id)
    {
        var imageUrl = _service.ImageUrlService.GetImageUrl(id, trackChanges: false);
        return Ok(imageUrl);
    }

    [HttpPost]
    [Consumes(typeof(ImageUrlForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Create(ImageUrlForCreationDto imageUrl)
    {
        if (imageUrl is null)
            return BadRequest("ImageUrlForCreationDto is null");

        var createdImageUrl = _service.ImageUrlService.CreateImageUrl(imageUrl);

        return CreatedAtRoute("ImageUrlById", new { id = createdImageUrl.Id }, createdImageUrl);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteImageUrl(Guid id)
    {
        _service.ImageUrlService.DeleteImageUrl(id, trackChanges: false);

        return NoContent();
    }

    /*
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateImageURLRequest model)
        {
            _imageUrlService.Update(id, model);
            return Ok(new { message = "ImageUrl updated" });
        }


        */
}