namespace CustomLibrary.ProblemDetails.Exception;

public class NotModifiedException : System.Exception
{
    public NotModifiedException()
    {
    }

    public NotModifiedException(string message) : base(message)
    {
    }

    public NotModifiedException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}