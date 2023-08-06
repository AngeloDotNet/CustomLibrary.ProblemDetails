namespace CustomLibrary.ProblemDetails.Response;

public class Confirm
{
    public HttpStatusCode StatusCode { get; }
    public bool Success { get; set; }
    public object Message { get; set; }

    public Confirm()
    {
        StatusCode = HttpStatusCode.OK;
        Success = true;
    }

    public Confirm(object message)
    {
        StatusCode = HttpStatusCode.OK;
        Success = true;
        Message = message;
    }

    public Confirm(HttpStatusCode statusCode, bool success)
    {
        StatusCode = statusCode;
        Success = success;
    }

    public Confirm(HttpStatusCode statusCode, bool success, object message)
    {
        StatusCode = statusCode;
        Success = success;
        Message = message;
    }
}