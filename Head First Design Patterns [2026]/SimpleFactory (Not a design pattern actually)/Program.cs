using FactoryPattern;

const string message = "This is a notification message";

var factory = new NotificationFactory();

INotification smsNotification = factory.Create(NotificationType.Sms);
smsNotification.SendNotification(message);

INotification emailNotification = factory.Create(NotificationType.Email);
emailNotification.SendNotification(message);

INotification pushNotification = factory.Create(NotificationType.Push);
pushNotification.SendNotification(message);
