namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

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

    /*
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var imageUrl = _imageUrlService.GetById(id);
        return Ok(imageUrl);
    }

    [HttpPost]
    public IActionResult Create(CreateImageURLRequest model)
    {
        _imageUrlService.Create(model);
        return Ok(new { message = "ImageUrl created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateImageURLRequest model)
    {
        _imageUrlService.Update(id, model);
        return Ok(new { message = "ImageUrl updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _imageUrlService.Delete(id);
        return Ok(new { message = "ImageUrl deleted" });
    }
    */
}