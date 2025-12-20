
namespace DecoratorLiveExample;

public abstract class CoffeeDecorator : ICoffee // don't want create object from this class
{
    protected ICoffee _coffee;
    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }
}
