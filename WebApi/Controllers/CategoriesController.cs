namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Entities.Models;
using WebApi.Entities.RequestFeatures;
using WebApi.ModelBinders;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly IServiceManager _service;

    public CategoriesController(
            IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Category>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllCategories()
    {
        try
        {
            var categories = await _service.CategoryService.GetAllCategoriesAsync(trackChanges: false);

            return Ok(categories);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Category>), StatusCodes.Status200OK)]
    [Route("filter/")]
    public async Task<IActionResult> GetAllCategoriesAsync([FromQuery] CategoryParameters categoryParameters)
    {
        try
        {
            var categories = await _service.CategoryService.GetAllCategoriesAsync(categoryParameters, false);

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
    public async Task<IActionResult> GetById(Guid id)
    {
        var category = await _service.CategoryService.GetCategoryAsync(id, trackChanges: false);
        return Ok(category);
    }

    [HttpGet("collection/({ids})", Name = "CategoryCollection")]
    [Consumes(typeof(CategoryForCreationDto), "application/json")]
    public async Task<IActionResult> GetCategoryCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))]IEnumerable<Guid> ids)
    {
        var category = await _service.CategoryService.GetByIdsAsync(ids, trackChanges: false);

        return Ok(category);
    }

    [HttpPost("collection")]    
    public async Task<IActionResult> CreateCategoryCollection([FromBody] IEnumerable<CategoryForCreationDto> categoryCollection)
    {
        var resut = await _service.CategoryService.CreateCategoryCollectionAsync(categoryCollection);
        
        return CreatedAtRoute("GetCategoryCollection", new { resut.ids }, resut.categories);
    }

    [HttpPost]
    [Consumes(typeof(CategoryForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Create([FromBody] CategoryForCreationDto category)
    {
        if (category is null)
            return BadRequest("CategoryForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);

        var createdCategory = await _service.CategoryService.CreateCategoryAsync(category);

        return CreatedAtRoute("CategoryById", new { id = createdCategory.Id }, createdCategory);
    }

    [HttpPut("{id:guid}")]
    [Consumes(typeof(CategoryForUpdateDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateCategory(Guid id, [FromBody]CategoryForUpdateDto categry)
    {
        if (categry is null)
            return BadRequest("CategoryForUpdateDto object is null");

        await _service.CategoryService.UpdateCategoryAsync(id, categry, trackChanges: true);
        
        return NoContent();
    }

    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteCategory(Guid id)
    {
        await _service.CategoryService.DeleteCategoryAsync(id, trackChanges: false);
        return NoContent();
    }
}