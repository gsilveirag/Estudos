using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swicht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Segunda";
                    break;

                case 2:
                    day = "Terca";
                    break;

                case 3:
                    day = "Quarta";
                    break;

                default:
                    day = "Valor invalido";
                    break;

            }
            Console.WriteLine(day);
            Console.ReadLine();


            // Exemplo de condicional ( Sem usar if / else ) //
            Console.WriteLine("Digite o preco:");
            double preco = double.Parse(Console.ReadLine());

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
            Console.ReadLine();

        }
    }
}
