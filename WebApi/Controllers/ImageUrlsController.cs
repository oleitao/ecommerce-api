namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
    public async Task<IActionResult> GetAllImageUrls()
    {
        var imageUrls = await _service.ImageUrlService.GetAllImageUrlsAsync(trackChanges: false);

        return Ok(imageUrls);
    }

    [HttpGet("{id:guid}", Name = "GetImageUrlById")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ImageUrl), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ImageUrl), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetImageUrlById(Guid id)
    {
        var imageUrl = await _service.ImageUrlService.GetImageUrlAsync(id, trackChanges: false);
        return Ok(imageUrl);
    }

    [HttpPost]
    [Consumes(typeof(ImageUrlForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateImageUrlAsync(ImageUrlForCreationDto imageUrl)
    {
        if (imageUrl is null)
            return BadRequest("ImageUrlForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdImageUrl = await _service.ImageUrlService.CreateImageUrlAsync(imageUrl);

        return CreatedAtRoute("GetImageUrlById", new { id = createdImageUrl.Id }, createdImageUrl);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteImageUrl(Guid id)
    {
        await _service.ImageUrlService.DeleteImageUrlAsync(id, trackChanges: false);

        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateImageUrl(int id, ImageUrlForUpdateDto imageUrl)
    {
        if (imageUrl is null)
            return BadRequest("ImageUrlForUpdateDto object is null");

        await _service.ImageUrlService.UpdateImageUrlAsync(id, imageUrl, trackChanges: true);
        
        return NoContent();
    }
}