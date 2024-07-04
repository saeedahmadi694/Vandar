namespace Vandar.ExceptionHandler;

public class VandarHtppHandler : Exception
{
    public string ResponseContent { get; }

    public VandarHtppHandler(string message, string responseContent = null) : base(message)
    {
        ResponseContent = responseContent;
    }

    public VandarHtppHandler(string message, Exception innerException) : base(message, innerException)
    {
    }
}
