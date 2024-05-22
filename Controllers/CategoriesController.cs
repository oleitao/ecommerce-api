namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Models.Categories;
using WebApi.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class CategoriesController : ControllerBase
{
    private ICategoryService _categoryService;
    private IMapper _mapper;

    public CategoriesController(
        ICategoryService categoryService,
        IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Entities.Category>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var users = _categoryService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Entities.Category), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Entities.Category), StatusCodes.Status404NotFound)]
    public IActionResult GetById(int id)
    {
        var user = _categoryService.GetById(id);
        return Ok(user);
    }

    [HttpPost]
    [Consumes(typeof(CreateCategoryRequest), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Create(CreateCategoryRequest model)
    {
        _categoryService.Create(model);
        return Ok(new { message = "Category created" });
    }

    [HttpPut("{id}")]
    [Consumes(typeof(UpdateCategoryRequest), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Update(int id, UpdateCategoryRequest model)
    {
        _categoryService.Update(id, model);
        return Ok(new { message = "Category updated" });
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        _categoryService.Delete(id);
        return Ok(new { message = "Category deleted" });
    }
}