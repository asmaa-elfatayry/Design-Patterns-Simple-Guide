
namespace DecoratorLiveExample;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }
    public override string GetDescription()
    {
        return _coffee.GetDescription() + " Milk Feature!";
    }
    public override double GetCost()
    {
        return _coffee.GetCost() + 10;
    }
}
