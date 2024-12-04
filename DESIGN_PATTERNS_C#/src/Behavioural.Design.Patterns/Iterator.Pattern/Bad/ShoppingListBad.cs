namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Iterator.Pattern.Bad;

public class ShoppingListBad
{
    private List<string> _shoppingList = new List<string>();
    // private string[] _shoppingList = new string[50];

    public void Push(string name)
    {
        _shoppingList.Add(name);
    }

    public string Pop()
    {
        string last = _shoppingList.Last();
        _shoppingList.Remove(last);
        return last;
    }

    public List<string> GetShoppingList()
    {
        return _shoppingList;
    }

}
