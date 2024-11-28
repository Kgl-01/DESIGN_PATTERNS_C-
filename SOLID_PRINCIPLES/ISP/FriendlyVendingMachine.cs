using SOLID_PRINCIPLES.DIP;

namespace SOLID_PRINCIPLES.ISP;

public class FriendlyVendingMachine : IVendingMachine, ICanGreet, ICanTellTime
{

    private readonly IMenuLoader _menuLoader;

    public FriendlyVendingMachine(IMenuLoader menuLoader)
    {
        _menuLoader = menuLoader;
    }


    public void SayHello()
    {
        System.Console.WriteLine("Please enter your name:");
        var userName = System.Console.ReadLine();
        System.Console.WriteLine($"Hello dear {userName}! How are you? \n");
    }

    public void TellTime()
    {
        var currentDate = DateTime.Now;
        System.Console.WriteLine($"Current time is {currentDate:d} at {currentDate:t}! \n");
    }

    public void DisplayMenu()
    {


        var products = _menuLoader.LoadMenu();

        foreach (var product in products)
        {
            System.Console.WriteLine(product);
        }
    }

    public void SayBye()
    {
        System.Console.Write("Press any key to exit...");
        Console.ReadKey(true);
    }

    public void Start()
    {
        SayHello();
        TellTime();
        DisplayMenu();
        SayBye();
    }

}
