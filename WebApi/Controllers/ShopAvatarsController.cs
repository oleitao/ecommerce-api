namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebApi.Service.Contracts;

[ApiController]
[Route("api/v1/[controller]")]
public class ShopAvatarsController : ControllerBase
{
    private readonly IServiceManager _service;

    public ShopAvatarsController(
        IServiceManager service)
    {
        _service = service;
    }

    /*
    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<ShopAvatar>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var shopAvatars = _shopAvatarService.GetAll();

        _logger.LogInfo("Here is info message from our values controller.");
        _logger.LogDebug("Here is debug message from our values controller.");
        _logger.LogWarn("Here is warn message from our values controller.");
        _logger.LogError("Here is an error message from our values controller.");

        return Ok(shopAvatars);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var shopAvatar = _shopAvatarService.GetById(id);
        return Ok(shopAvatar);
    }

    [HttpPost]
    public IActionResult Create(CreateShopAvatarRequest model)
    {
        _shopAvatarService.Create(model);
        return Ok(new { message = "ShopAvatar created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateShopAvatarRequest model)
    {
        _shopAvatarService.Update(id, model);
        return Ok(new { message = "ShopAvatar updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _shopAvatarService.Delete(id);
        return Ok(new { message = "ShopAvatar deleted" });
    }
    */
}