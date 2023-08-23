namespace CustomLibrary.ProblemDetails.Exception;

public class NotAcceptableException : System.Exception
{
    public NotAcceptableException()
    {
    }

    public NotAcceptableException(string message) : base(message)
    {
    }

    public NotAcceptableException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}