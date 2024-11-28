using SOLID_PRINCIPLES.Model;

namespace SOLID_PRINCIPLES.SRP;

public class PriceTagMaker
{
    public virtual string MakePriceTagForProduct(Product product)
    {
        return $"${product.Price:0.##}";
    }
}
