//Порушення принципу підстановки Лісков (LSP)
//Квадрат не є підтипом прямокутника, тому клас Square не може коректно наслідувати Rectangle. Це призводить до некоректного результату.

//Виправлення: Виділити спільний інтерфейс або базовий клас для геометричних фігур.
abstract class Shape
{
    public abstract int GetArea();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int GetArea() => Width * Height;
}

class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea() => Side * Side;
}

class Program
{
    static void Main(string[] args)
    {
        Shape rect = new Rectangle { Width = 5, Height = 10 };
        Shape square = new Square { Side = 5 };

        Console.WriteLine(rect.GetArea()); 
        Console.WriteLine(square.GetArea()); 

        Console.ReadKey();
    }
}
