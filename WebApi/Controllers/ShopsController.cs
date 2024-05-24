namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
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
    /*
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Shop>), StatusCodes.Status200OK)]
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