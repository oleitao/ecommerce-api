namespace WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApi.Entities;
using WebApi.Entities.Exceptions;
using WebApi.Helpers;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

[ApiController]
[ApiVersion(version: VersionHelper.ApiVersion)]
[Route("api/v{version:apiVersion}/[controller]")]
public class RolesController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    const string key = $"{nameof(CategoryDto)}";
    public RolesController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
    {
        _service = service;

        _client = client;
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("webApiCachingApp", "1.0"));
        _redis = muxer.GetDatabase();
        _cache = cache;
        _muxer = muxer;
    }

    [HttpGet("{id:guid}", Name = "GetRoleByUserId")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    public async Task<IActionResult> GetProfileRole(Guid id)
    {
        var userRole = await _service.UserService.GetUserRolesById(id);
        if (string.IsNullOrEmpty(userRole))
            throw new RoleNotFoundException(id);


        string response = string.Empty;

        switch (userRole)
        {
            case RolesHelper.AdminNormalzed:
                response = "/profile-admin";
                break;
            case RolesHelper.SellerNormalzed:
                response = "/shop/:";
                break;
            default:
                response = "/profile";
                break;
        }

        return Ok(response);
    }
}