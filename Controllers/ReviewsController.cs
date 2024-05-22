namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Categories;
using WebApi.Models.Users;
using WebApi.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ReviewsController : ControllerBase
{
    private IReviewService _reviewService;
    private IMapper _mapper;

    public ReviewsController(
        IReviewService reviewService,
        IMapper mapper)
    {
        _reviewService = reviewService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _reviewService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _reviewService.GetById(id);
        return Ok(user);
    }

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
}