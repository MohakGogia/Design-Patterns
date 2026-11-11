namespace FactoryPattern.ConcreteCreators;

public class SMSNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new SMSNotification();
    }
}
