using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> list = new List<Empregado>();

            int n;
            Console.WriteLine("Digite a quantidade de funcionarios:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= n; i++)
            {
                Console.WriteLine("Digite a ID do funcionario:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do funcionario:");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o salario do funcionario:");
                double salario = double.Parse(Console.ReadLine());
                Empregado e = new Empregado(id, name, salario);
                list.Add(e);
            }
            Console.Write("Algum funcionario tera aumento? S/N ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine();
                Console.Write("Digite o CPF do funcionário que terá aumento: ");
                int cpfBuscado = int.Parse(Console.ReadLine());
                int pos = list.FindIndex(x => x.Id == cpfBuscado);
                if (pos == -1)
                {
                    Console.WriteLine("CPF INEXISTENTE");

                }
                else
                {
                    Console.Write("Digite a porcentagem de aumento: ");
                    double porc = double.Parse(Console.ReadLine());
                    list[pos].aumentarSalario(porc);
                }
            }

            
            Console.WriteLine();
            Console.WriteLine("Listagem atualizada de funcionários:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            Console.ReadLine();

        }
    }
}
