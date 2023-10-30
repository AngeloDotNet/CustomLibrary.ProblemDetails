namespace CustomLibrary.ProblemDetails;

public static class ResponseException
{
    public static ObjectResult NotModified(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status304NotModified;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "NotModified"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult BadRequest(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status400BadRequest;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "BadRequest"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult Unauthorized(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status401Unauthorized;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "Unauthorized"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult Forbidden(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status403Forbidden;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "Forbidden"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult NotFound(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status404NotFound;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "NotFound"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult MethodNotAllowed(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status405MethodNotAllowed;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "MethodNotAllowed"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult NotAcceptable(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status406NotAcceptable;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "NotAcceptable"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult RequestTimeout(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status408RequestTimeout;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "RequestTimeout"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult Conflict(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status409Conflict;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "Conflict"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult UnprocessableEntity(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status422UnprocessableEntity;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "UnprocessableEntity"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult InternalServerError(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status500InternalServerError;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "InternalServerError"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult NotImplemented(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status501NotImplemented;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "InternalServerError"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult BadGateway(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status502BadGateway;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "BadGateway"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult ServiceUnavailable(HttpContext httpContext, System.Exception exc, List<string> validationError = null)
    {
        var statusCode = StatusCodes.Status503ServiceUnavailable;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Detail = exc.Message,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "ServiceUnavailable"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        //problemDetails.Extensions.Add("errors", exc.Message);

        if (validationError?.Any() ?? false)
        {
            problemDetails.Extensions.Add("errors", validationError);
        }

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }
}