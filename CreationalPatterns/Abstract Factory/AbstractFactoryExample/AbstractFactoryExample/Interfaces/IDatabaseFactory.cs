
namespace AbstractFactoryExample.Interfaces;

public interface IDatabaseFactory // Abstract Factory -> بيرجع مجموعة Products مترابطة
{
    IDbConnection CreateConnection();
    IDbCommand CreateCommand();
}
