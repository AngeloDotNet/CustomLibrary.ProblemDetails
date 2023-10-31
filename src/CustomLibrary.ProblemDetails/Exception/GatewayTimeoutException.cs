namespace CustomLibrary.ProblemDetails.Exception;

public class GatewayTimeoutException : System.Exception
{
    public GatewayTimeoutException()
    {
    }

    public GatewayTimeoutException(string message) : base(message)
    {
    }

    public GatewayTimeoutException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}