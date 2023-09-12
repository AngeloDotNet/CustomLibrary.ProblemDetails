namespace CustomLibrary.ProblemDetails.Exception;

public class UnprocessableEntityException : System.Exception
{
    public UnprocessableEntityException()
    {
    }

    public UnprocessableEntityException(string message) : base(message)
    {
    }

    public UnprocessableEntityException(string message, System.Exception innerException) : base(message, innerException)
    {
    }
}