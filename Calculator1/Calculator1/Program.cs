using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("--------------------");

            Console.WriteLine("Selecione uma opcao.");
            byte res = byte.Parse(Console.ReadLine());

            switch (res)

            {
                case 0: System.Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.WriteLine();
            Console.WriteLine("Soma.");
            Console.WriteLine("Primeiro Valor");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro Segundo");
            float n2 = float.Parse(Console.ReadLine());

            var total = n1 + n2;

            Console.WriteLine("");
            Console.WriteLine("O somatorio entre esses dois valores foi de: " + total);
            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para continuar.");
            Console.ReadLine();
            Console.Clear();
            Menu();

        }
        static void Subtracao()
        {
            Console.WriteLine();
            Console.WriteLine("Subtracao.");
            Console.WriteLine("Primeiro Valor");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro Segundo");
            float n2 = float.Parse(Console.ReadLine());

            var total = n1 - n2;

            Console.WriteLine("");
            Console.WriteLine("A subtracao entre esses dois valores foi de: " + total);
            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para continuar.");
            Console.ReadLine();
            Console.Clear();
            Menu();
        }
        static void Divisao()
        {

            Console.WriteLine();
            Console.WriteLine("Divisao.");
            Console.WriteLine("Primeiro Valor");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro Segundo");
            float n2 = float.Parse(Console.ReadLine());

            var total = n1 / n2;

            Console.WriteLine("");
            Console.WriteLine("A Divisao entre esses dois valores foi de: " + total);
            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para continuar.");
            Console.ReadLine();
            Console.Clear();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.WriteLine();
            Console.WriteLine("Multiplicacao.");
            Console.WriteLine("Primeiro Valor");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro Segundo");
            float n2 = float.Parse(Console.ReadLine());

            var total = n1 * n2;

            Console.WriteLine("");
            Console.WriteLine("A multiplicacao entre esses dois valores foi de: " + total);
            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para continuar.");
            Console.ReadLine();
            Console.Clear();
            Menu();
        }
    }
}
