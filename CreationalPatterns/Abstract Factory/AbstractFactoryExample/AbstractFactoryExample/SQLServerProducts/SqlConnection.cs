

using AbstractFactoryExample.Interfaces;

namespace AbstractFactoryExample.SQLServerProducts;

public class SqlConnection :IDbConnection
{
    public void Connect()
    {
        Console.WriteLine("Connected to SQL Server");
    }
}
