namespace WebApi.Helpers;

using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Security.Authentication;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi.Entities.Exceptions;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "An exception occurred: {Message}", exception.Message);
            await HandleExceptionAsync(httpContext, exception);
        }
    }
    #region private actions
    private async static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
    {
        (int httpStatusCode, string error) = GetStatusCode(exception);

        httpContext.Response.ContentType = "application/json";
        httpContext.Response.StatusCode = httpStatusCode;

        await httpContext.Response.WriteAsync(JsonSerializer.Serialize(new CustomResponse
        {
            Error = error,
            Message = exception.Message
        }));
    }

    private static (int, string) GetStatusCode(Exception exception)
        => exception switch
        {
            BadRequestException => (StatusCodes.Status400BadRequest, "Bad Request"),
            AuthenticationException => (StatusCodes.Status403Forbidden, "Forbidden"),
            NotFoundException => (StatusCodes.Status404NotFound, "Not Found"),
            _ => (StatusCodes.Status500InternalServerError, "Internal Server Error")
        };
    #endregion
    public class CustomResponse
    {
        public string? Error { get; set; }
        public string? Message { get; set; }
    }
}