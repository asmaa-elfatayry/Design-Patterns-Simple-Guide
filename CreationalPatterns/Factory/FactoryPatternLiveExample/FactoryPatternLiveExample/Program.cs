using FactoryPatternLiveExample;

#region without factory pattern

//client will handle the creation
//string type = "Email";
//string message = "Welcome to our system!";

//if (type == "Email")
//{
//    EmailNotification email = new EmailNotification();
//    email.Send(message);
//}
//else if (type == "SMS")
//{
//    SmsNotification sms = new SmsNotification();
//    sms.Send(message);
//}
//else if (type == "Push")
//{
//    PushNotification push = new PushNotification();
//    push.Send(message);
//}
#endregion

INotification notify = NotificationFactory.CreateNotification("Email");
notify.Send("Welcome to our system!");

INotification notification =
    NotificationFactory.CreateNotification("SMS");

notification.Send("Hello from SMS");



