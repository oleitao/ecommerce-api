namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;
using WebApi.Services;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly IServiceManager _service;
    private IMapper _mapper;
    private LoggerManager _logger;

    public CategoriesController(
            IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Category>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        try
        {
            var categories = _service.CategoryService.GetAllCategories(trackChanges: false);

            return Ok(categories);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }
    
    [HttpGet("{id:guid}")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Category), StatusCodes.Status404NotFound)]
    public IActionResult GetById(Guid id)
    {
        var category = _service.CategoryService.GetCategory(id, trackChanges: false);
        return Ok(category);
    }
/*
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
    */
}