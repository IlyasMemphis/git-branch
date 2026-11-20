using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Пример 2
            Product product = new Product();
            product.Title = textBox1.Text;
            product.Price = decimal.Parse(textBox2.Text);
            product.Quantity = int.Parse(textBox3.Text);

            // Пример 3
            Order order = new Order(
                int.Parse(textBox4.Text),
                textBox5.Text,
                decimal.Parse(textBox6.Text)
            );

            // Пример 4
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.Celsius = double.Parse(textBox7.Text);

            labelResult.Text =
                $"Товар: {product.Title}\n" +
                $"Цена: {product.Price}\n" +
                $"Количество: {product.Quantity}\n\n" +
                $"Номер заказа: {order.Id}\n" +
                $"Покупатель: {order.CustomerName}\n" +
                $"Сумма заказа: {order.TotalAmount}\n\n" +
                $"Цельсий: {sensor.Celsius}\n" +
                $"Фаренгейт: {sensor.Fahrenheit}";
        }
    }

    // Пример 2
    public class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    // Пример 3
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

    // Пример 4
    public class TemperatureSensor
    {
        private double _celsius;

        public double Celsius
        {
            get => _celsius;
            set
            {
                if (value < -273.15)
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "Температура ниже абсолютного нуля невозможна.");

                _celsius = value;
            }
        }

        public double Fahrenheit
        {
            get => (_celsius * 9.0 / 5.0) + 32;
        }
    }
}
