

using AbstractFactoryExample.Interfaces;
using AbstractFactoryExample.SQLServerProducts;

namespace AbstractFactoryExample.Factories;

public class SqlFactory : IDatabaseFactory
{
    public IDbCommand CreateCommand()
    {
        return new SqlCommand();
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection();
    }
}
