using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio__Heranca_.Entitie;

namespace Exercicio__Heranca_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write(" Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used, or imported (c/u/i)?");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());


                if (resp == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (resp == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else 
                {
                     list.Add(new Product(name, price));
                }


            }

            Console.WriteLine();
            Console.WriteLine("Price tags: ");
            foreach(Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
