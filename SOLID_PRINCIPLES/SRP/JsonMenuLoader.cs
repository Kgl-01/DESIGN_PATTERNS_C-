using System.Text.Json;
using SOLID_PRINCIPLES.DIP;
using SOLID_PRINCIPLES.Model;


namespace SOLID_PRINCIPLES.SRP;

public class JsonMenuLoader : IMenuLoader
{
    public List<Product> LoadMenu()
    {
        string text = File.ReadAllText(@"C:\Users\karth\OneDrive\Desktop\DESIGN_PATTERNS_C#\SOLID_PRINCIPLES\Data\menu.json");
        return JsonSerializer.Deserialize<List<Product>>(text);
    }
}
