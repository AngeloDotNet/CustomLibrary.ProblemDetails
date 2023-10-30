namespace CustomLibrary.ProblemDetails.Exception;

public class ServiceUnavailableException : System.Exception
{
    public ServiceUnavailableException()
    {
    }

    public ServiceUnavailableException(string message) : base(message)
    {
    }

    public ServiceUnavailableException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}