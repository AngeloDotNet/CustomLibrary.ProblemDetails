namespace CustomLibrary.ProblemDetails.Exception;

public class ConflictException : System.Exception
{
    public ConflictException()
    {
    }

    public ConflictException(string message) : base(message)
    {
    }

    public ConflictException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}