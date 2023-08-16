public class CustomException : Exception
{
    public CustomException() : base("Custom exception")
    {

    }

    public CustomException(string message) : base(message)
    {
        
    }
}