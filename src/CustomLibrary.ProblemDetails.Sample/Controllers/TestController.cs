using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace CustomLibrary.ProblemDetails.Sample.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class TestController : ControllerBase
{
    public TestController()
    {
    }

    [HttpGet("NotModified-Exception")]
    public async Task<IActionResult> GetExceptionNotModifiedAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.NotModifiedException("Not Modified");
        }
        catch (Exception.NotModifiedException exc)
        {
            return ResponseException.NotModified(HttpContext, exc);
        }
    }

    [HttpGet("BadRequest-Exception")]
    public async Task<IActionResult> GetExceptionBadRequestAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.BadRequestException("Bad Request");
        }
        catch (Exception.BadRequestException exc)
        {
            return ResponseException.BadRequest(HttpContext, exc);
        }
    }

    [HttpGet("Unauthorized-Exception")]
    public async Task<IActionResult> GetExceptionUnauthorizedAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.UnauthorizedException("Unauthorized");
        }
        catch (Exception.UnauthorizedException exc)
        {
            return ResponseException.Unauthorized(HttpContext, exc);
        }
    }

    [HttpGet("Forbidden-Exception")]
    public async Task<IActionResult> GetExceptionForbiddenAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.ForbiddenException("Forbidden");
        }
        catch (Exception.ForbiddenException exc)
        {
            return ResponseException.Forbidden(HttpContext, exc);
        }
    }

    [HttpGet("NotFound-Exception")]
    public async Task<IActionResult> GetExceptionNotFoundAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.NotFoundException("Not Found");
        }
        catch (Exception.NotFoundException exc)
        {
            return ResponseException.NotFound(HttpContext, exc);
        }
    }

    [HttpGet("MethodNotAllowed-Exception")]
    public async Task<IActionResult> GetExceptionMethodNotAllowedAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.NotAllowedException("Method Not Allowed");
        }
        catch (Exception.NotAllowedException exc)
        {
            return ResponseException.MethodNotAllowed(HttpContext, exc);
        }
    }

    [HttpGet("NotAcceptable-Exception")]
    public async Task<IActionResult> GetExceptionNotAcceptableAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.NotAcceptableException("Not Acceptable");
        }
        catch (Exception.NotAcceptableException exc)
        {
            return ResponseException.NotAcceptable(HttpContext, exc);
        }
    }

    [HttpGet("RequestTimeout-Exception")]
    public async Task<IActionResult> GetExceptionRequestTimeoutAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.RequestTimeoutException("Request Timeout");
        }
        catch (Exception.RequestTimeoutException exc)
        {
            return ResponseException.RequestTimeout(HttpContext, exc);
        }
    }

    [HttpGet("Conflict-Exception")]
    public async Task<IActionResult> GetExceptionConflictAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.ConflictException("Conflict");
        }
        catch (Exception.ConflictException exc)
        {
            return ResponseException.Conflict(HttpContext, exc);
        }
    }

    [HttpGet("UnprocessableEntity-Exception")]
    public async Task<IActionResult> GetExceptionUnprocessableEntityAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.UnprocessableEntityException("Unprocessable Entity");
        }
        catch (Exception.UnprocessableEntityException exc)
        {
            return ResponseException.UnprocessableEntity(HttpContext, exc);
        }
    }

    [HttpGet("InternalServerError-Exception")]
    public async Task<IActionResult> GetExceptionInternalServerErrorAsync()
    {
        try
        {
            await Task.Delay(500);
            throw new Exception.InternalServerErrorException("Internal Server Error");
        }
        catch (Exception.InternalServerErrorException exc)
        {
            return ResponseException.InternalServerError(HttpContext, exc);
        }
    }
}