namespace WebApi.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApi.Entities.Exceptions;
using WebApi.Helpers;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[ApiVersion(version: VersionHelper.ApiVersion)]
[Route("api/v{version:apiVersion}/[controller]")]
public class SellersController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    const string key = $"{nameof(UserDto)}";

    public SellersController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
    {
        _service = service;

        _client = client;
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("webApiCachingApp", "1.0"));
        _redis = muxer.GetDatabase();
        _cache = cache;
        _muxer = muxer;
    }

    [HttpPut("{id:guid}")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Consumes(typeof(SellerForUpdateDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateSeller(Guid id, SellerForUpdateDto sellerUpdate)
    {
        try
        {
            var user = await _service.UserService.GetUserAsync(id, trackChanges: true);
            if (user is null)
                return BadRequest("UserDto object is null");

            if (sellerUpdate is null)
                return BadRequest("SellerForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.UserService.UpdateSellerAsync(id, sellerUpdate, trackChanges: true);

            return Ok();
        }
        catch
        {
            return NotFound();
        }
    }
}