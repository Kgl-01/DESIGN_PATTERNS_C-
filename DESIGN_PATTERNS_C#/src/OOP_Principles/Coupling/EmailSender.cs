namespace DESIGN_PATTERNS_C_.src.OOP_Principles.Coupling;

public class EmailSender : INotificationService
{

    public void SendNotification(string message)
    {
        System.Console.WriteLine($"Sending email: {message}");
    }

}
