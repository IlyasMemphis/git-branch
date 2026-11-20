using System;

public class Product
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class Order
{
    public int Id { get; private set; }
    public string CustomerName { get; set; }
    public decimal TotalAmount { get; private set; }

    public Order(int id, string customerName, decimal totalAmount)
    {
        Id = id;
        CustomerName = customerName;
        TotalAmount = totalAmount;
    }
}

public class TemperatureSensor
{
    private double _celsius;

    public double Celsius
    {
        get => _celsius;
        set
        {
            if (value < -273.15)
                throw new ArgumentOutOfRangeException(nameof(value),
                    "Температура ниже абсолютного нуля невозможна.");
            _celsius = value;
        }
    }

    public double Fahrenheit
    {
        get => (_celsius * 9.0 / 5.0) + 32;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Product product = new Product();
            Console.Write("Название товара: ");
            product.Title = Console.ReadLine();
            Console.Write("Цена: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Количество: ");
            product.Quantity = int.Parse(Console.ReadLine());
    
            Console.Write("Номер заказа: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Имя покупателя: ");
            string customerName = Console.ReadLine();
            Console.Write("Сумма заказа: ");
            decimal totalAmount = decimal.Parse(Console.ReadLine());
            Order order = new Order(id, customerName, totalAmount);
    
            TemperatureSensor sensor = new TemperatureSensor();
            Console.Write("Температура в градусах Цельсия: ");
            sensor.Celsius = double.Parse(Console.ReadLine());
    
            Console.WriteLine();
            Console.WriteLine("Товар: " + product.Title);
            Console.WriteLine("Цена: " + product.Price);
            Console.WriteLine("Количество: " + product.Quantity);
            Console.WriteLine();
            Console.WriteLine("Номер заказа: " + order.Id);
            Console.WriteLine("Покупатель: " + order.CustomerName);
            Console.WriteLine("Сумма заказа: " + order.TotalAmount);
            Console.WriteLine();
            Console.WriteLine("Цельсий: " + sensor.Celsius);
            Console.WriteLine("Фаренгейт: " + sensor.Fahrenheit);
        }
        catch (Exception ex)
        {
            if (ex is FormatException)
                Console.WriteLine("Ошибка: введено неверное значение. Там, где требуется число, введите число.");
            else if (ex is OverflowException)
                Console.WriteLine("Ошибка: введено слишком большое или слишком маленькое число.");
            else
                Console.WriteLine("Ошибка: " + ex.Message);
            Console.ReadLine();
        }
    }
}
