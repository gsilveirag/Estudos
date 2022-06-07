using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            int N;
            Console.WriteLine("Quantos funcionarios voce vai digitar?");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite o ID:");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Nome:");
                string Nome = Console.ReadLine();
                Console.WriteLine("Digite o Salario:");
                double Salario = double.Parse(Console.ReadLine());
                Funcionario f = new Funcionario(Id, Nome, Salario);
                lista.Add(f);
            }

            Console.WriteLine("Deseja aumentar o salario do funcionario? S/N");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'S' || resp == 's')
            {
                Console.WriteLine("Digite o ID para aumento");
                int idbuscar = int.Parse(Console.ReadLine());

                int pos = lista.FindIndex(x => x.Id == idbuscar);

                if (pos == -1)
                {
                    Console.WriteLine("Erro ! ID nao encontrado");
                }
                else
                {
                    Console.Write("Digite a porcentagem de aumento: ");
                    double porc = double.Parse(Console.ReadLine());
                    lista[pos].AumentodeSalario(porc);
                }

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Listagem atualizada de funcionários:");
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine(lista[i]);
                }
            }

        Console.ReadLine();
        }
    }
}
