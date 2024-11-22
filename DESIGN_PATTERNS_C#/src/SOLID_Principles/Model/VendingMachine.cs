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
            using FileStream fileStream = new FileStream("../Data/menu.json", FileMode.Open, FileAccess.Read);
            var products = JsonSerializer.Deserialize<List<Product>>(fileStream);


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
