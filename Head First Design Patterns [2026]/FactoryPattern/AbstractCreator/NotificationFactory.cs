namespace FactoryPattern;

public abstract class NotificationCreator
{
    protected abstract INotification CreateNotification();

    public void SendNotification(string message)
    {
        INotification notification = CreateNotification();
        notification.SendNotification(message);
    }
}
