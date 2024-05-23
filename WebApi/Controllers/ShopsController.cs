namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Models.Users;
using WebApi.Services;

[ApiController]
[Route("api/v1/[controller]")]
public class ShopsController : ControllerBase
{
    private IShopService _shopService;
    private IMapper _mapper;
    private ILoggerManager _logger;

    public ShopsController(
        IShopService shopService,
        IMapper mapper,
        ILoggerManager logger)
    {
        _shopService = shopService;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Entities.Shop>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var shops = _shopService.GetAll();

        _logger.LogInfo("Here is info message from our values controller.");
        _logger.LogDebug("Here is debug message from our values controller.");
        _logger.LogWarn("Here is warn message from our values controller.");
        _logger.LogError("Here is an error message from our values controller.");

        return Ok(shops);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var shop = _shopService.GetById(id);
        return Ok(shop);
    }

    [HttpPost]
    public IActionResult Create(CreateShopRequest model)
    {
        _shopService.Create(model);
        return Ok(new { message = "Category created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateShopRequest model)
    {
        _shopService.Update(id, model);
        return Ok(new { message = "Category updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _shopService.Delete(id);
        return Ok(new { message = "Category deleted" });
    }
}