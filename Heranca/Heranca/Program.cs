using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 500.0);
            Account acc1 = new SavingsAccount (1001, "Alex", 500.0, 0.01);

            acc.Withdraw(10.0);
            acc1.Withdraw(10.0);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc1.Balance);

            Console.ReadLine();
        }
    }
}
