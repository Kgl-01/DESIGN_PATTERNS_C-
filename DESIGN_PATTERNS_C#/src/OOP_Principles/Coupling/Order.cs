namespace DESIGN_PATTERNS_C_.src.OOP_Principles.Coupling;

public class Order

{
    private readonly INotificationService _notificationService;

    public Order(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }


    public void PlaceOrder()
    {
        //Place Order logic...
        _notificationService.SendNotification("Order placed successsfully!");
    }
}
