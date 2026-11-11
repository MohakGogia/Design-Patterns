namespace FactoryPattern;

public class NotificationFactory
{
    public INotification Create(NotificationType type)
    {
        if (type == NotificationType.Sms)
        {
            return new SMSNotification();
        }

        if (type == NotificationType.Email)
        {
            return new EmailNotification();
        }
        
        if (type == NotificationType.Push)
        {
            return new PushNotification();
        }
        
        throw new ArgumentOutOfRangeException(nameof(type), type, "Unknown notification type");
    }
}
