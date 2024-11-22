namespace DESIGN_PATTERNS_C_.src.SOLID_Principles.Model;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Type { get; set; }
    public override string ToString()
    {
        return "Product";
    }
}

