namespace Inventory;

public class Inventory
{
    // Добавил инициализацию списка
    private List<Item> _items = new();

    private int _maxWeight;
    private int _weight;

    public int MaxWeight => _maxWeight;

    public int Weight => _weight;

    public Inventory(int maxWeight)
    {
        _maxWeight = maxWeight;
    }

    public bool AddItem(Item item, int count)
    {
        if (_weight + item.Weight * count > _maxWeight)
        {
            return false;
        }

        for (int i = 0; i < count; i++)
        {
            _items.Add(item);
        }

        _weight += item.Weight * count;

        return true;
    }

    public bool RemoveItem(Item item)
    {
        // Добавил логику снятия веса при удалении предмета
        _weight -= item.Weight;
        return _items.Remove(item);
    }

    public int CountItem(Item countItem)
    {
        int c = 0;
        // Убрал =

        // Добавил логику для подсчёта нужного предмета, а не всех
        for (int i = 0; i < _items.Count; i++)
        {
            if (_items[i].Name == countItem.Name)
                c++;
        }

        return c;
    }
}