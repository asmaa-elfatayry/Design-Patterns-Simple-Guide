
namespace DecoratorLiveExample;

public class SimpleCoffee : ICoffee
{
    public double GetCost()
    {
        return 50;
    }

    public string GetDescription()
    {
        return "Simple Coffee";
    }
}
