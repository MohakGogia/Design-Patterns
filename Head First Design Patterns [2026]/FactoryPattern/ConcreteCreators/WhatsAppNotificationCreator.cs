namespace FactoryPattern.ConcreteCreators;

public class WhatsAppNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new WhatsAppNotification();
    }
}
