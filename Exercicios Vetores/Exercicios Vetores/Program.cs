using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos seram alugados?");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] vet = new Aluguel[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite seu nome?");
                string nome = Console.ReadLine();
                Console.WriteLine("Email?");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto a ser alugado?");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Aluguel { Nome = nome, Email = email };
            }
            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {    
                    Console.WriteLine(i + ": " + vet[i]);
                   
                }

            }
        
            Console.ReadLine();
        }
    }
}
