namespace WebApi.Controllers;

using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Authorization;
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

    [HttpPost]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [Consumes(typeof(RoleDto), "application/json")]
    public async Task<IActionResult> UserMapByRole([FromBody] RoleDto request)
    {
        string response = string.Empty;

        if (request.Id.HasValue) {

            var userRole = await _service.UserService.GetUserRolesById(request.Id.Value);
            if (string.IsNullOrEmpty(userRole))
                throw new RoleNotFoundException(request.Id.Value);

            if (request is not null)
            {
                switch (userRole)
                {
                    case RolesHelper.AdminNormalzed:
                        RolesHelper.Admins.TryGetValue(request.Tag, out response);
                        break;
                    case RolesHelper.SellerNormalzed:
                        RolesHelper.Sellers.TryGetValue(request.Tag, out response);
                        break;
                    case RolesHelper.UserNormalzed:
                        RolesHelper.Users.TryGetValue(request.Tag, out response);
                        break;
                    default:
                        response = string.Empty;
                        break;
                }
            }
        }

        return Ok(response);
    }
}