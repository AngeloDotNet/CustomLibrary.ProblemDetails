namespace CustomLibrary.ProblemDetails.Exception;

public class NotAllowedException : System.Exception
{
    public NotAllowedException()
    {
    }

    public NotAllowedException(string message) : base(message)
    {
    }

    public NotAllowedException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}