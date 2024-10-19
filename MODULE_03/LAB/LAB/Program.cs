using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    public class OrderService
    {
        public void CreateOrder(string productName, int quantity, double price)
        {
            LogOrder("created", productName, quantity, price);
        }

        public void UpdateOrder(string productName, int quantity, double price)
        {
            LogOrder("updated", productName, quantity, price);
        }

        private void LogOrder(string action, string productName, int quantity, double price)
        {
            double totalPrice = quantity * price;
            Console.WriteLine($"Order for {productName} {action}. Total: {totalPrice}");
        }
    }

    // Общий базовый класс
    public abstract class Vehicle
    {
        public abstract void Start();
        public abstract void Stop();
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stopping");
        }
    }

    public class Truck : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Truck is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Truck is stopping");
        }
    }

    // Класс калькулятора с упрощенной логикой
    public class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }

    // Упрощенный сервис без использования шаблона Singleton
    public class SimpleService
    {
        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }

    public class Client
    {
        private readonly SimpleService _service;

        public Client(SimpleService service)
        {
            _service = service;
        }

        public void Execute()
        {
            _service.DoSomething();
        }
    }

    // Определения фигур без избыточных абстракций
    public class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Square
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }

        public double CalculateArea()
        {
            return _side * _side;
        }
    }

    // Упрощенные математические операции
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program
    {
    }
}
