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
    private ILoggerManager _logger;

    public ReviewsController(
        IReviewService reviewService,
        IMapper mapper,
        ILoggerManager logger)
    {
        _reviewService = reviewService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var reviews = _reviewService.GetAll();

        _logger.LogInfo("Here is info message from our values controller.");
        _logger.LogDebug("Here is debug message from our values controller.");
        _logger.LogWarn("Here is warn message from our values controller.");
        _logger.LogError("Here is an error message from our values controller.");

        return Ok(reviews);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var review = _reviewService.GetById(id);
        return Ok(review);
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