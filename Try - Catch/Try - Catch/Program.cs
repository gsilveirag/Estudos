using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Try___Catch.Entities;
using Try___Catch.Entities.Exceptions;

namespace Try___Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Checkin: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkout: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());



                Reservetion reservetion = new Reservetion(number, checkIn, checkOut);

                Console.WriteLine("Reserva: " + reservetion);

                Console.WriteLine();
                Console.WriteLine("Updates: ");
                Console.Write("Checkin: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Checkout: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservetion.UpdateDates(checkIn, checkOut);


                Console.WriteLine(reservetion);
             }
            catch(DomainException e)
            {
                Console.WriteLine("Error" + e.Message);
            }





            Console.ReadLine();
        }
    }
}
