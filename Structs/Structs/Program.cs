using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o tamanho do seu vetor");
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome");
                string name = Console.ReadLine();
                Console.WriteLine("Digite os valores");
                double valor     = double.Parse(Console.ReadLine());
                vet[i] = new Produto { Nome = name, Valor = valor };   
            }

            double soma = 0;
            for (int j = 0; j < n; j++)
            {
                soma += vet[j].Valor;
            }

            double avg = soma / n;

            Console.WriteLine("Media: "+ avg.ToString("F2"));

            Console.ReadLine();

            
        }
    }
}
