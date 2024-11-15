namespace DESIGN_PATTERNS_C_.src.OOP_Principles.Abstraction;

public class EmailService
{
    public void SendEmail()
    {
        Connect();
        Authenticate();
        System.Console.WriteLine("Sending Email...");
        Disconnect();
    }

    private void Connect()
    {
        System.Console.WriteLine("Connecting to email server");
    }

    private void Authenticate()
    {
        System.Console.WriteLine("Authenticating...");
    }

    private void Disconnect()
    {
        System.Console.WriteLine("Disconnect from all email server");
    }


}
