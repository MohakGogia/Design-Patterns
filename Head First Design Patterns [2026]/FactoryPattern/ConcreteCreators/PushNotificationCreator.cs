namespace FactoryPattern.ConcreteCreators;

public class PushNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new PushNotification();
    }
}
