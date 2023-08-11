namespace CustomLibrary.ProblemDetails.Exception;

public class ForbiddenException : System.Exception
{
    public ForbiddenException()
    {
    }

    public ForbiddenException(string message) : base(message)
    {
    }

    public ForbiddenException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}