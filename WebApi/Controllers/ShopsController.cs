namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;

[ApiController]
[Route("api/[controller]")]
public class ShopsController : ControllerBase
{
    private readonly IServiceManager _service;

    public ShopsController(
            IServiceManager service)
    {
        _service = service;
    }
    
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Shop>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        try
        {
            var shops = _service.ShopService.GetAllShops(trackChanges: false);

            return Ok(shops);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }
    
    /*
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
        return Ok(new { message = "Shop created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateShopRequest model)
    {
        _shopService.Update(id, model);
        return Ok(new { message = "Shop updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _shopService.Delete(id);
        return Ok(new { message = "Shop deleted" });
    }
    */
}