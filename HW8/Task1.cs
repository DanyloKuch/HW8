using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// порушено Single Responsibility Principle
//клас Order виконує кілька різних задач
//виправлення :
//окремий клас для роботи з товарними елементами замовлення OrderItemManager
//окремий клас для зберігання та завантаження даних OrderPersistence
//  Окремий клас для представлення друку чи відображення замовлення OrderPrinter

namespace HW8
{
    class Item
    {
        public int Price;
    }

    class Order
    {
        private List<Item> itemList;

        public Order()
        {
            itemList = new List<Item>();
        }

        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        public void DeleteItem(Item item)
        {
            itemList.Remove(item);
        }

        public List<Item> GetItems()
        {
            return itemList;
        }

        public int GetItemCount()
        {
            return itemList.Count;
        }

        public decimal CalculateTotalSum()
        {
            decimal total = 0;
            foreach (var item in itemList)
            {
                
                total += item.Price;
            }
            return total;
        }
    }

    class OrderPersistence
    {
        public void Save(Order order)
        {
         
        }

        public void Load(Order order)
        {
           
        }

        public void Update(Order order)
        {
            
        }

        public void Delete(Order order)
        {
            
        }
    }

    class OrderPrinter
    {
        public void PrintOrder(Order order)
        {
           
        }

        public void ShowOrder(Order order)
        {
           
        }
    }

}
