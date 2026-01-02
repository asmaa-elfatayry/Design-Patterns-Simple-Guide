
using AbstractFactoryExample.Interfaces;
namespace AbstractFactoryExample.SQLServerProducts;

public class SqlCommand : IDbCommand
{
    public void Execute()
    {
        Console.WriteLine("Execute SQL Command");
    }
}
