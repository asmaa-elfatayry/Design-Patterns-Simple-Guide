

namespace BridgeExample;

public class WirelessConnection : IConnection
{
    public void Connect(string headphoneType)
    {
        Console.WriteLine($"{headphoneType} connected via Wireless 📶");
    }
}
