//Порушення принципу розділення інтерфейсу (ISP)
//Інтерфейс IItem занадто великий і містить методи, які не потрібні всім класам.
//Виправлення: Розділити інтерфейс на менші.
interface IDiscountable
{
    void ApplyDiscount(string discount);
}

interface IPromocodeApplicable
{
    void ApplyPromocode(string promocode);
}

interface IPricable
{
    void SetPrice(double price);
}

interface IClothingItem
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : IPricable, IDiscountable
{
    public double Price { get; private set; }

    public void SetPrice(double price) => Price = price;
    public void ApplyDiscount(string discount)
    {
    }
}

class Clothing : IPricable, IDiscountable, IClothingItem
{
    public double Price { get; private set; }
    public byte Color { get; private set; }
    public byte Size { get; private set; }

    public void SetPrice(double price) => Price = price;
    public void ApplyDiscount(string discount)
    {
    }

    public void SetColor(byte color) => Color = color;
    public void SetSize(byte size) => Size = size;
}
