

namespace BridgeExample;

public class WiredConnection:IConnection
{
    public void Connect(string headphoneType)
    {
        Console.WriteLine($"{headphoneType} connected via Wired 🔌");
    }
}
