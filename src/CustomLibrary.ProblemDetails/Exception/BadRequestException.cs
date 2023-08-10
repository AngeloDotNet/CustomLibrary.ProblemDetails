namespace CustomLibrary.ProblemDetails.Exception;

public class BadRequestException : System.Exception
{
    public BadRequestException()
    {
    }

    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}