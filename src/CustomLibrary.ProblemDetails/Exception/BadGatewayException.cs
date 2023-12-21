namespace CustomLibrary.ProblemDetails.Exception;
public class BadGatewayException : System.Exception
{
    public BadGatewayException()
    {
    }

    public BadGatewayException(string message) : base(message)
    {
    }

    public BadGatewayException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}