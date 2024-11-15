//Inheritence

using DESIGN_PATTERNS_C_.src.OOP_Principles.Coupling;

INotificationService notificationService = new SmsSender();

var order = new Order(notificationService);

order.PlaceOrder();

