namespace CustomLibrary.ProblemDetails.Exception;

public class NotFoundException : System.Exception
{
    public NotFoundException()
    {
    }

    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}