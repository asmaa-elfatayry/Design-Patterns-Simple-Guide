using AbstractFactoryExample;
using AbstractFactoryExample.Factories;
using AbstractFactoryExample.Interfaces;

//IDatabaseFactory factory = new SqlFactory();
 IDatabaseFactory factory = new OracleFactory();

DatabaseClient client = new DatabaseClient(factory);
client.Run();