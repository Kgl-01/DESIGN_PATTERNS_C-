using SOLID_PRINCIPLES.Model;

namespace SOLID_PRINCIPLES.DIP;

public interface IMenuLoader
{
    List<Product> LoadMenu();
}
