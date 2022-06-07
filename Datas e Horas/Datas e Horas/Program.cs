using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas_e_Horas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            

            Console.WriteLine(dateTime.ToString());

            Console.WriteLine(dateTime.ToLongDateString());

         

            Console.ReadLine();
        }
    }
}
