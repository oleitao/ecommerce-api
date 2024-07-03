namespace WebApi.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApi.Entities.Exceptions;
using WebApi.Helpers;
using WebApi.Service.Contracts;

[ApiController]
[ApiVersion(version: VersionHelper.ApiVersion)]
[Route("api/v{version:apiVersion}/email")]
public class EmailController : ControllerBase
{
    private readonly IEmailSender _emailSender;

    public EmailController(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    [HttpGet("accountvalidation/{id}", Order = 0)]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [Route("")]
    [AllowAnonymous]
    public async Task AccountValidation(Guid id)
    {        
        var user = await _emailSender.GetUserAsync(id, trackChanges: false);

        var content = await _emailSender.GetContent(EmailHelper.AccountValidation, user, trackChanges: false);
        if (content is null)
            throw new EmailContentNotFound(EmailHelper.AccountValidation);
        
        await _emailSender.SendEmailAsync(user.Email, content);
    }

    [HttpGet("infopayment/{id}", Order = 1)]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [AllowAnonymous]
    public async Task InfoPayment(Guid id)
    {
        var user = await _emailSender.GetUserAsync(id, trackChanges: false);

        var content = await _emailSender.GetContent(EmailHelper.AccountPayment, user, trackChanges: false);
        if (content is null)
            throw new EmailContentNotFound(EmailHelper.AccountPayment);

        await _emailSender.SendEmailAsync(user.Email, content);
    }

    [HttpGet("Newsletter/{id}", Order = 2)]
    [HttpGet("{id:guid}")]
    [ApiVersion(version: VersionHelper.ApiVersion)]
    [ApiExplorerSettings(GroupName = "v1")]
    [Produces("application/json")]
    [AllowAnonymous]
    public async Task SendNewsletter(Guid id)
    {
        var user = await _emailSender.GetUserAsync(id, trackChanges: false);

        var content = await _emailSender.GetContent(EmailHelper.Newsletter, user, trackChanges: false);
        if (content is null)
            throw new EmailContentNotFound(EmailHelper.Newsletter);

        await _emailSender.SendEmailAsync(user.Email, content);
    }
}