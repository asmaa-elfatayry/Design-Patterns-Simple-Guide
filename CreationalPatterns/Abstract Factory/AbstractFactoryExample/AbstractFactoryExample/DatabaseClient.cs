
using AbstractFactoryExample.Interfaces;


namespace AbstractFactoryExample;

public class DatabaseClient
{
    private Interfaces.IDbCommand dbCommand;
    private Interfaces.IDbConnection dbConnection;

    public DatabaseClient(IDatabaseFactory databaseFactory)
    {
        dbConnection = databaseFactory.CreateConnection();
        dbCommand = databaseFactory.CreateCommand();
    }

    public void Run()
    {
        dbConnection.Connect();
        dbCommand.Execute();
    }
}
