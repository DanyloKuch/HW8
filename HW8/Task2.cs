//Клас EmailSender займається як відправкою повідомлень, так і логуванням, що порушує SRP.

//Виправлення: Винести логування в окремий клас.
class Email
{
    public string Theme { get; set; }
    public string From { get; set; }
    public string To { get; set; }
}

// Логування винесено в окремий клас
class Logger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class EmailSender
{
    private readonly Logger _logger;

    public EmailSender(Logger logger)
    {
        _logger = logger;
    }

    public void Send(Email email)
    {
        _logger.Log($"Email from '{email.From}' to '{email.To}' was sent");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();
        EmailSender emailSender = new EmailSender(logger);

        Email email = new Email() { From = "Me", To = "Vasya", Theme = "Hello!" };
        emailSender.Send(email);

        Console.ReadKey();
    }
}
