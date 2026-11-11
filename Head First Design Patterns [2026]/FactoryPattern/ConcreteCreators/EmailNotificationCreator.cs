namespace FactoryPattern.ConcreteCreators;

public class EmailNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}
