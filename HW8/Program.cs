using HW8;

class Program
{
    static void Main(string[] args)
    {

        // Завдання 2
        Console.WriteLine("Завдання 2: Принцип єдиної вiдповiдальностi з EmailSender");
        Email email1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        ILogger logger = new ConsoleLogger();
        EmailSender emailSender = new EmailSender(logger);
        emailSender.Send(email1);
        Console.WriteLine();

        // Завдання 3
        Console.WriteLine("Завдання 3: Принцип замiщення Лiсков");
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine($"Rectangle Area: {rect.GetRectangleArea()}");

        Square square = new Square();
        square.Side = 5;
        Console.WriteLine($"Square Area: {square.GetArea()}");
        Console.WriteLine();

        // Завдання 4
        Console.WriteLine("Завдання 4: Принцип роздiлення iнтерфейсу");
        Book book = new Book();
        book.SetPrice(15.99);
        book.ApplyDiscount("10% off");

        Clothing clothing = new Clothing();
        clothing.SetPrice(49.99);
        clothing.ApplyDiscount("20% off");
        clothing.ApplyPromocode("SUMMER21");
        clothing.SetColor(255);
        clothing.SetSize(42);

        Console.ReadKey();
    }
}