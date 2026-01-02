

using AbstractFactoryExample.Interfaces;

namespace AbstractFactoryExample.OracleProducts;

public class OracleCommand :IDbCommand
{
    public void Execute()
    {
        Console.WriteLine("Execute Oracle Command");
    }
}
