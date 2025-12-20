
using DecoratorLiveExample;

ICoffee coffee = new SimpleCoffee();
// simple coffee
Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost());

coffee = new MilkDecorator(coffee); // pass the simple coffee to milk decorator to add milk to coffee
Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost());

coffee = new SugarDecorator(coffee);// pass the coffee with milk to sugar decorator to add sugar 
Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost());

//SimpleCoffee
//MilkDecorator // MilkDecorator : CoffeeDecorator : ICoffee
//SugarDecorator
// all in the end is coffee