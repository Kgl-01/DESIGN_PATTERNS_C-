using System.Text.Json;
using SOLID_PRINCIPLES.DIP;
using SOLID_PRINCIPLES.ISP;
using SOLID_PRINCIPLES.SRP;

namespace SOLID_PRINCIPLES.Model;

public class VendingMachine : IVendingMachine
{


    private IMenuLoader _menuLoader;

    public VendingMachine(IMenuLoader menuLoader)
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
        // Previous Logic
        // try
        // {
        //     string text = File.ReadAllText(@"C:\Users\karth\OneDrive\Desktop\DESIGN_PATTERNS_C#\SOLID_PRINCIPLES\Data\menu.json");
        //     var products = JsonSerializer.Deserialize<List<Product>>(text);


        //     foreach (var product in products)
        //     {
        //         System.Console.WriteLine(product.ToString());
        //     }
        // }
        // catch (DirectoryNotFoundException ex)
        // {
        //     System.Console.WriteLine(ex.Message);
        // }

        // var menuLoader = new JsonMenuLoader();

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
