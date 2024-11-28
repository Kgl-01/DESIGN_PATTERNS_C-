using SOLID_PRINCIPLES.DIP;
using SOLID_PRINCIPLES.Model;

namespace SOLID_PRINCIPLES.ISP;

public class HighPerformanceVendingMachine : IVendingMachine
{
    private readonly IMenuLoader _menuLoader;

    public HighPerformanceVendingMachine(IMenuLoader menuLoader)
    {
        _menuLoader = menuLoader;

    }


    public void DisplayMenu()
    {
        List<Product> products = _menuLoader.LoadMenu();

        foreach (Product product in products)
        {
            System.Console.WriteLine(product);
        }

    }

    public void Start()
    {
        DisplayMenu();
    }


}
