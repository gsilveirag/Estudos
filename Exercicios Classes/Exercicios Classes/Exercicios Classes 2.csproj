using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario s = new Salario();
            Console.WriteLine("Digite seu nome:");
            s.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu Salario:");
            s.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o imposto pago:");
            s.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(s);

            Console.WriteLine();
            Console.WriteLine("Digite quantos porcento voce quer aumentar do salario:");
            double p = double.Parse(Console.ReadLine());
            s.AumentarSalario(p);

            Console.WriteLine("Dados Atualizados:" + s );

            Console.ReadLine();

        }
    }
}
