namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
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

    /*
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<ImageUrl>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var imageUrls = _imageUrlService.GetAll();

        _logger.LogInfo("Here is info message from our values controller.");
        _logger.LogDebug("Here is debug message from our values controller.");
        _logger.LogWarn("Here is warn message from our values controller.");
        _logger.LogError("Here is an error message from our values controller.");

        return Ok(imageUrls);
    }

    
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