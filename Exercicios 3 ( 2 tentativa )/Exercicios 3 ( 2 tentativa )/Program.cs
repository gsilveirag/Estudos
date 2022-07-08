using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios_3___2_tentativa__.Entities.Enum;
using Exercicios_3___2_tentativa__.Entities;

namespace Exercicios_3___2_tentativa__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: (Pending / Processing / Shipped / Delivered) ");
            Enum.TryParse(Console.ReadLine(), out OrderStatus status);
            

            Client client = new Client (name, email, date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, priceProduct);


                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, priceProduct, product);

                order.Items.Add(orderItem);

            }

            Console.WriteLine(order);
            Console.ReadLine();

        }
    }
}
