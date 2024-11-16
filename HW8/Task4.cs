using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    // Принцип порушено: Принцип розділення інтерфейсу (Interface Segregation Principle).
    // Проблема: Інтерфейс IItem містить занадто багато методів, які не є необхідними для кожного класу.
    // Клас Book не потребує методів для кольору чи розміру, а клас Clothing не потребує методів для знижок чи промокодів для товарів, де це не застосовно.

    // Рішення: Розділити великий інтерфейс на кілька менших і специфічних інтерфейсів. Кожен клас буде реалізовувати тільки потрібні йому інтерфейси.

    interface IDiscountable
    {
        void ApplyDiscount(string discount);
    }

    interface IPromocodable
    {
        void ApplyPromocode(string promocode);
    }

    interface IColorable
    {
        void SetColor(byte color);
    }

    interface ISizeable
    {
        void SetSize(byte size);
    }

    interface IPriceable
    {
        void SetPrice(double price);
    }

    // Клас для книг
    class Book : IPriceable, IDiscountable
    {
        public double Price { get; set; }

        public void ApplyDiscount(string discount)
        {
            // Реалізація знижки для книги
            Console.WriteLine($"Discount applied: {discount}");
        }

        public void SetPrice(double price)
        {
            Price = price;
            Console.WriteLine($"Price set for book: {Price}");
        }
    }

    // Клас для одягу
    class Clothing : IPriceable, IDiscountable, IPromocodable, IColorable, ISizeable
    {
        public double Price { get; set; }
        public byte Color { get; set; }
        public byte Size { get; set; }

        public void ApplyDiscount(string discount)
        {
            // Реалізація знижки для одягу
            Console.WriteLine($"Discount applied: {discount}");
        }

        public void ApplyPromocode(string promocode)
        {
            // Реалізація промокоду для одягу
            Console.WriteLine($"Promocode applied: {promocode}");
        }

        public void SetColor(byte color)
        {
            Color = color;
            Console.WriteLine($"Color set for clothing: {Color}");
        }

        public void SetSize(byte size)
        {
            Size = size;
            Console.WriteLine($"Size set for clothing: {Size}");
        }

        public void SetPrice(double price)
        {
            Price = price;
            Console.WriteLine($"Price set for clothing: {Price}");
        }
    }

   
}
