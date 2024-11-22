using System.Text.Json;
using System.Text.Json.Nodes;

namespace DESIGN_PATTERNS_C_.src.SOLID_Principles.Model;

public class VendingMachine
{
    private void SayHello()
    {
        System.Console.WriteLine("Please enter your name:");
        var userName = System.Console.ReadLine();
        System.Console.WriteLine($"Hello dear {userName}! How are you? \n");
    }

    private void TellTime()
    {
        var currentDate = DateTime.Now;
        System.Console.WriteLine($"Current time is {currentDate:d} at {currentDate:t}! \n");
    }

    private void DisplayMenu()
    {
        try
        {
            string text = File.ReadAllText(@"C:\Users\karth\OneDrive\Desktop\DESIGN_PATTERNS_C#\DESIGN_PATTERNS_C#\src\SOLID_Principles\Data\menu.json");
            var products = JsonSerializer.Deserialize<List<Product>>(text);


            foreach (var product in products)
            {
                System.Console.WriteLine(product.ToString());
            }
        }
        catch (DirectoryNotFoundException ex)
        {
            System.Console.WriteLine(ex.Message);
        }

    }

    private void SayBye()
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
