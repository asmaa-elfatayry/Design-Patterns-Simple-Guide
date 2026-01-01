
namespace ProxyExample;

public class RealDocument :IDocument
{
    public void Open()
    {
        Console.WriteLine("Document opened");
    }
}
