

namespace BridgeExample;

internal class OverEar : Headphone
{
    public OverEar(IConnection connection) : base("OverEar Headphone", connection) { }
    public override void PlayMusic()
    {
        _connection.Connect(_headphoneType); // الأول نوصل السماعة بطريقة الاتصال
        Console.WriteLine("Playing music on OverEar Headphone 🎶"); // بعدين نلعب موسيقى
    }
}
