namespace CustomLibrary.ProblemDetails.Response;

public static class Response
{
    public static ObjectResult NotModified(HttpContext httpContext, System.Exception exc)
    {
        var statusCode = StatusCodes.Status304NotModified;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "NotModified"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        problemDetails.Extensions.Add("errors", exc.Message);

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }

    public static ObjectResult BadRequest(HttpContext httpContext, System.Exception exc)
    {
        var statusCode = StatusCodes.Status400BadRequest;
        var problemDetails = new CustomProblemDetails
        {
            Status = statusCode,
            Type = $"https://httpstatuses.com/{statusCode}",
            Instance = httpContext.Request.Path,
            Title = "BadRequest"
        };

        problemDetails.Extensions.Add("traceId", Activity.Current?.Id ?? httpContext.TraceIdentifier);
        problemDetails.Extensions.Add("errors", exc.Message);

        var result = new ObjectResult(problemDetails)
        {
            StatusCode = statusCode
        };

        return result;
    }
}