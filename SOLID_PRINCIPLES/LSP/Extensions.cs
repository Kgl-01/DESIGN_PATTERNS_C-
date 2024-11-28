using SOLID_PRINCIPLES.Model;
using SOLID_PRINCIPLES.OCP;
using SOLID_PRINCIPLES.SRP;

namespace SOLID_PRINCIPLES.LSP;

public static class Extensions
{
    public static PriceTagMaker GetPriceTagMaker(this Product product)
    {

        switch (product.Type)
        {
            case "Drink":
                return new DrinkTypePriceTagMaker();
            case "Fruit":
                return new FruitTypePriceTagMaker();
            default:
                return new PriceTagMaker();
        }
    }
}
