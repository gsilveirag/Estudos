using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum.Entities;
using Enum.Entities.Enums;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

        Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);


            Console.ReadLine(); 
            

        }
    }
}
