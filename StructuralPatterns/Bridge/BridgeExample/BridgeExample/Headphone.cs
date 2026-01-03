

namespace BridgeExample;

abstract class Headphone
{
    protected IConnection _connection;
    protected string _headphoneType;
    public Headphone(string type, IConnection connection)
    {
        _headphoneType = type; //  نوع السماعة
        _connection = connection; //  طريقة الاتصال
    }

    public abstract void PlayMusic(); 
}
