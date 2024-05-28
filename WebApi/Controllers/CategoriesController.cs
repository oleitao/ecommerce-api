namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.ModelBinders;
using WebApi.Service.Contracts;
using WebApi.Services;
using WebApi.Shared.DataTransferObjects;

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
    
    [HttpGet("{id:guid}", Name = "CategoryById")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Category), StatusCodes.Status404NotFound)]
    public IActionResult GetById(Guid id)
    {
        var category = _service.CategoryService.GetCategory(id, trackChanges: false);
        return Ok(category);
    }

    [HttpGet("collection/({ids})", Name = "CategoryCollection")]
    [Consumes(typeof(CategoryForCreationDto), "application/json")]
    public IActionResult GetCategoryCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))]IEnumerable<Guid> ids)
    {
        var category = _service.CategoryService.GetByIds(ids, trackChanges: false);

        return Ok(category);
    }

    [HttpPost("collection")]    
    public IActionResult CreateCategoryCollection([FromBody] IEnumerable<CategoryForCreationDto> categoryCollection)
    {
        var resut = _service.CategoryService.CreateCategoryCollection(categoryCollection);

        return Ok(resut);
        //return CreatedAtRoute("GetCategoryCollection", new { resut.ids }, resut.categories);
    }

    [HttpPost]
    [Consumes(typeof(CategoryForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Create([FromBody] CategoryForCreationDto category)
    {
        if (category is null)
            return BadRequest("CategoryForCreationDto is null");

        var createdCategory = _service.CategoryService.CreateCategory(category);

        return CreatedAtRoute("CategoryById", new { id = createdCategory.Id }, createdCategory);
    }


    /*
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