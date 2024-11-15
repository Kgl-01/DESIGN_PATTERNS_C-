namespace DESIGN_PATTERNS_C_.src.OOP_Principles.Coupling;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        //Sms Logic
        System.Console.WriteLine($"Send SMS: {message}");
    }

}
