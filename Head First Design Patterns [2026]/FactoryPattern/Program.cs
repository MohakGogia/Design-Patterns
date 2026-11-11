using FactoryPattern;
using FactoryPattern.ConcreteCreators;

const string message = "This is a notification message";

NotificationCreator creatorA = new SMSNotificationCreator();
creatorA.SendNotification(message);

NotificationCreator creatorB = new EmailNotificationCreator();
creatorB.SendNotification(message);

NotificationCreator creatorC = new WhatsAppNotificationCreator();
creatorC.SendNotification(message);
