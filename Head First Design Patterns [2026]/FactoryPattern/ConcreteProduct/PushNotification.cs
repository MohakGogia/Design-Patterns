namespace FactoryPattern;

public class PushNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending Push notification: {message}");
    }
}
