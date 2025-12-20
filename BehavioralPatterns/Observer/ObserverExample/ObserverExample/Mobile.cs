using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample;

// Concrete Observer (موبايل محدد)
public class Mobile : IObserver
{
    private string _name;
    public Mobile(string name) { _name = name; }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received update: {message}");
    }
}
