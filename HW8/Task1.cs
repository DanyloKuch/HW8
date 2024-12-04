// Клас Order порушує SRP, оскільки виконує кілька завдань: керування списком товарів, розрахунок суми, друк замовлення, збереження/завантаження даних тощо.

//Виправлення: Розбити клас на кілька класів, кожен із яких відповідає за одну функцію.
class Item
{
}

class Order
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item) => items.Add(item);
    public void DeleteItem(Item item) => items.Remove(item);
    public List<Item> GetItems() => items;
}

class OrderCalculator
{
    public decimal CalculateTotalSum(Order order)
    {
        return 0m;
    }
}

class OrderPrinter
{
    public void PrintOrder(Order order)
    {
    }
}

class OrderRepository
{
    public void Save(Order order)
    {
    }

    public Order Load(int orderId)
    {
        return new Order();
    }
}
