namespace DESIGN_PATTERNS_C_.src.OOP_Principles.Abstraction;

public class EmailService
{
    public void SendEmail()
    {
        Connect();
        Authenticate();
        Console.WriteLine("Sending Email...");
        Disconnect();
    }

    private void Connect()
    {
        Console.WriteLine("Connecting to email server");
    }

    private void Authenticate()
    {
        Console.WriteLine("Authenticating...");
    }

    private void Disconnect()
    {
        Console.WriteLine("Disconnect from all email server");
    }


}
