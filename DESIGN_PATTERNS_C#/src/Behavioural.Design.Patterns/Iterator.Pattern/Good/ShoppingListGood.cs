namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Iterator.Pattern.Good;

public class ShoppingListGood
{
    private List<string> _list = new List<string>();

    public void Push(string item)
    {
        _list.Add(item);
    }

    public string Pop()
    {
        var item = _list.Last();
        _list.Remove(item);
        return item;
    }

    public IIterator<string> CreateIterator()
    {
        return new ListIterator(this);
    }



    private class ListIterator : IIterator<string>
    {
        private ShoppingListGood _shoppingList;
        private int _index;

        public ListIterator(ShoppingListGood shoppingList)
        {
            _shoppingList = shoppingList;
        }

        public string Current()
        {
            return _shoppingList._list[_index];
        }

        public bool HasNext()
        {
            return _index < _shoppingList._list.Count;
        }

        public void Next()
        {
            _index++;
        }
    }


}
