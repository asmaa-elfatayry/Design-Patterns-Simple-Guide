
namespace ProxyExample;

public class DocumentProxy : IDocument
{
    private RealDocument _realDocument;
    private string _role;

    public DocumentProxy(string role)
    {
        _role = role;
    }

    public void Open()
    {
        if (_role != "Admin")
        {
            Console.WriteLine("Access denied");
            return;
        }
        if (_realDocument == null)
        {
            _realDocument = new RealDocument();
        }

        _realDocument.Open();
    }
}
