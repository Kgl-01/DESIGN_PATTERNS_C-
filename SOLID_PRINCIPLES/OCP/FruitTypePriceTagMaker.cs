using SOLID_PRINCIPLES.Model;
using SOLID_PRINCIPLES.SRP;

namespace SOLID_PRINCIPLES.OCP;

public class FruitTypePriceTagMaker : PriceTagMaker
{

    public override string MakePriceTagForProduct(Product product)
    {
        var basePrice = base.MakePriceTagForProduct(product);
        return $"{basePrice} + ${product.Price * 0.05m:0.##} wrapping fee";
    }

}
