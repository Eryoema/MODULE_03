using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    // Общая конфигурация для подключения к базе данных
    public static class Config
    {
        public static string ConnectionString = "Server=myServer;Database=myDb;User Id=myUser;Password=myPass;";
    }

    // Универсальный метод логирования (DRY)
    public class LoggingService
    {
        public void Log(string message, string type)
        {
            Console.WriteLine($"{type.ToUpper()}: {message}");
        }
    }

    // Сервис для работы с базой данных (использование общей конфигурации - DRY)
    public class DatabaseService
    {
        public void Connect()
        {
            string connectionString = Config.ConnectionString;
            // Логика подключения к базе данных
        }
    }

    // Процессинг чисел с применением KISS (минимум вложений)
    public class NumberProcessor
    {
        public void ProcessNumbers(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return;

            foreach (var number in numbers)
            {
                if (number > 0)
                    Console.WriteLine(number);
            }
        }

        public void PrintPositiveNumbers(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number > 0)
                    Console.WriteLine(number);
            }
        }
    }

    // Простой метод деления с предварительной проверкой (KISS)
    public class MathOperations
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
                return 0;

            return a / b;
        }
    }

    // Упрощенный класс User с разделением обязанностей (YAGNI)
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

    public class UserRepository
    {
        public void SaveToDatabase(User user)
        {
            // Логика сохранения пользователя в базу данных
        }
    }

    public class EmailService
    {
        public void SendEmail(string email)
        {
            // Логика отправки электронного письма
        }
    }

    public class AddressLabelPrinter
    {
        public void PrintAddressLabel(string address)
        {
            // Логика печати адресного ярлыка
        }
    }

    // Упрощенное чтение файла без ненужных параметров (YAGNI)
    public class FileReader
    {
        public string ReadFile(string filePath)
        {
            // Простая логика чтения файла
            return "file content";
        }
    }

    // Универсальная генерация отчетов (YAGNI)
    public class ReportGenerator
    {
        public void GenerateReport(string format)
        {
            // Логика генерации отчета в зависимости от формата
            Console.WriteLine($"Generating {format} report...");
        }
    }
    internal class Program
    {
    }
}
