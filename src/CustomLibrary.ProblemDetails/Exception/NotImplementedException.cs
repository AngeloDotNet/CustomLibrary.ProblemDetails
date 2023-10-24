namespace CustomLibrary.ProblemDetails.Exception;

public class NotImplementedException : System.Exception
{
    public NotImplementedException()
    {
    }

    public NotImplementedException(string message) : base(message)
    {
    }

    public NotImplementedException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}