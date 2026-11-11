namespace FactoryPattern;

public class EmailNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending Email notification: {message}");
    }
}
