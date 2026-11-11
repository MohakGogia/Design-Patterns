namespace FactoryPattern;

public class WhatsAppNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending WhatsApp notification: {message}");
    }
}
