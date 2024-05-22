namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Users;
using WebApi.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ImageUrlsController : ControllerBase
{
    private IImageUrlService _imageUrlService;
    private IMapper _mapper;

    public ImageUrlsController(
        IImageUrlService imageUrlService,
        IMapper mapper)
    {
        _imageUrlService = imageUrlService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _imageUrlService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _imageUrlService.GetById(id);
        return Ok(user);
    }

    [HttpPost]
    public IActionResult Create(CreateImageURLRequest model)
    {
        _imageUrlService.Create(model);
        return Ok(new { message = "Category created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateImageURLRequest model)
    {
        _imageUrlService.Update(id, model);
        return Ok(new { message = "Category updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _imageUrlService.Delete(id);
        return Ok(new { message = "Category deleted" });
    }
}