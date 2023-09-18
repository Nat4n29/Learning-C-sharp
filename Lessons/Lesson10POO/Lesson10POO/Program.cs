using Lesson10POO.Entities;
using Lesson10POO.Entities.Enums;
using System;
using System.Globalization;

namespace Lesson10OPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            order = new Order(DateTime.Now, status, client);

            for(int i = 1; i <= items; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProd, priceProd);
                OrderItem orderItem = new OrderItem(quantity, priceProd, product);
                order.Items.Add(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}