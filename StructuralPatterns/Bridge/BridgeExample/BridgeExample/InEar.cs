
namespace BridgeExample;

internal class InEar:Headphone
{
    public InEar(IConnection connection) : base("InEar Headphone", connection) { }

    public override void PlayMusic()
    {
        _connection.Connect(_headphoneType);
        Console.WriteLine("Playing music on InEar Headphone 🎶"); 
    }
}
