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
public class InboxController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly HttpClient _client;
    private readonly IDatabase _redis;
    private readonly IDistributedCache _cache;
    private readonly IConnectionMultiplexer _muxer;

    const string key = $"{nameof(CategoryDto)}";
    public InboxController(IServiceManager service, HttpClient client, IConnectionMultiplexer muxer, IDistributedCache cache)
    {
        _service = service;

        _client = client;
        _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("webApiCachingApp", "1.0"));
        _redis = muxer.GetDatabase();
        _cache = cache;
        _muxer = muxer;
    }


    [HttpGet("{to:guid}", Name = "InboxFrom")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(InboxDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(InboxDto), StatusCodes.Status404NotFound)]
    //[Authorize]
    public async Task<IActionResult> InboxFrom(Guid to)
    {
        var inboxInCache = await CacheHelper.GetKey<InboxDto>($"{key}:{to.ToString()}", _cache);
        if (inboxInCache is null)
        {
            var inboxInDatabase = await _service.CategoryService.GetCategoryAsync(to, trackChanges: false);
            if (inboxInDatabase is null)
                throw new InboxNotFoundException(to);

            CacheHelper.SetKey(inboxInDatabase ,$"{key}:{inboxInDatabase.Id}", _cache);

            return Ok(inboxInDatabase);
        }

        return Ok(inboxInCache);
    }

    [HttpPost]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]    
    [Consumes(typeof(InboxForCreationDto), "application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    //[Authorize]
    public async Task<IActionResult> CreateInbox([FromBody] InboxForCreationDto inbox)
    {
        if (inbox is null)
            return BadRequest("InboxForCreationDto is null");

        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState);


        var createdInbox = await _service.InboxService.CreateInboxAsync(inbox);

        CacheHelper.SetKey(createdInbox, $"{key}:{createdInbox.Id}", _cache);


        return Ok();
        //return CreatedAtRoute("CategoryById", new { id = createdInbox.Id }, createdInbox);
    }
}