using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_de_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("Entre com o numero da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta:");
            string titular = Console.ReadLine();

            Console.WriteLine("Havera deposito inicial?(s/n)");
            char resp = char.Parse(Console.ReadLine());
            if (resp ==  's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor de deposito:");
                double valor = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, valor);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("\nQuer fazer um deposito ?(s/n)");
            resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor de deposito:");
                double deposito = double.Parse(Console.ReadLine());
                conta.Deposito(deposito);

            }
            
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);


            Console.WriteLine("Havera um saque ?(s/n)");
            resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor de saque:");
                double saque = double.Parse(Console.ReadLine());
                conta.Saque(saque);
            }
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);   
            Console.ReadLine();
        }
    }
}
