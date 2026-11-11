namespace FactoryPattern;

public class SMSNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending SMS notification: {message}");
    }
}
