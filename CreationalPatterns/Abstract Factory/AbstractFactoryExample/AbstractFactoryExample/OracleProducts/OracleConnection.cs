
using AbstractFactoryExample.Interfaces;

namespace AbstractFactoryExample.OracleProducts;

public class OracleConnection :IDbConnection
{
    public void Connect()
    {
        Console.WriteLine("Connected to Oracle");
    }
}
