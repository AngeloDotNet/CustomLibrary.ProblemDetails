namespace CustomLibrary.ProblemDetails.Exception;

public class UnauthorizedException : System.Exception
{
    public UnauthorizedException()
    {
    }

    public UnauthorizedException(string message) : base(message)
    {
    }

    public UnauthorizedException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}