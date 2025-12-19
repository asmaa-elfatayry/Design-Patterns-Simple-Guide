using NullObjectExample;

bool enableLogging = true; 

ILogger logger = enableLogging ? new ConsoleLogger() : new NullLogger();

// هنا اختيار Null Object بيحمي Client لو enableLogging = false
logger.Log("Application started");
logger.Log("User clicked a button");

