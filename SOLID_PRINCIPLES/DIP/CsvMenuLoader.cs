using SOLID_PRINCIPLES.Model;

namespace SOLID_PRINCIPLES.DIP;

public class CsvMenuLoader : IMenuLoader
{
    public List<Product> LoadMenu()
    {
        List<Product> products = new List<Product>();

        using (var reader = new StreamReader(@"C:\Users\karth\OneDrive\Desktop\DESIGN_PATTERNS_C#\SOLID_PRINCIPLES\Data\menu.csv"))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(",");
                products.Add(new Product { ID = int.Parse(values[0]), Name = values[1], Price = decimal.Parse(values[2]), Type = values[3] });
            }
        }

        return products;
    }
}
