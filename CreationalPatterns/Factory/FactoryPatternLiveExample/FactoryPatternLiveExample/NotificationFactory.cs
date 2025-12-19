using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternLiveExample;

public class NotificationFactory
{
    public static INotification CreateNotification(string type)
    {
        return type switch
        {
            "Email" => new EmailNotification(),
            "SMS" => new SmsNotification(),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}
