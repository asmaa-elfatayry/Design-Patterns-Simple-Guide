

using AbstractFactoryExample.Interfaces;
using AbstractFactoryExample.OracleProducts;

namespace AbstractFactoryExample.Factories;

public class OracleFactory : IDatabaseFactory
{
    public IDbCommand CreateCommand()
    {
        return new OracleCommand();
    }

    public IDbConnection CreateConnection()
    {
        return new OracleConnection();
    }
}
