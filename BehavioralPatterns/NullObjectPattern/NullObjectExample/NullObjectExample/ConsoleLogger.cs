

namespace NullObjectExample;

public class ConsoleLogger:ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}
