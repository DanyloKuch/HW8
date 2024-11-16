using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    // Порушено принцип єдиної відповідальності (Single Responsibility Principle).
    // Клас EmailSender має кілька обов'язків: відправка листів та логування.
    // Виправлення: розділити логіку логування та відправки листів. Логування винести в окремий клас, що реалізує інтерфейс ILogger.

    class Email
    {
        public string Theme { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }

    // Інтерфейс для логування
    interface ILogger
    {
        void Log(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Клас для відправки електронних листів
    class EmailSender
    {
        private readonly ILogger _logger;

        // Конструктор приймає логер
        public EmailSender(ILogger logger)
        {
            _logger = logger;
        }

        public void Send(Email email)
        {
            // Відправка листа...
            _logger.Log($"Email from '{email.From}' to '{email.To}' was sent");
        }
    }

    

}
