using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternLiveExample;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}
