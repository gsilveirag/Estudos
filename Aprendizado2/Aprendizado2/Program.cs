using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aprendizado2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estoque e = new Estoque();

            Console.WriteLine("Entre com os dados do produto:\n");
            Console.WriteLine("Digite o nome do produto");
            e.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preco do produto");
            e.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produto");
            e.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(e);

            Console.WriteLine("\nDigite a quantidade de produtos para adicionar");
            int qte = int.Parse(Console.ReadLine());
            e.AdicionarProdutos(qte);
            Console.WriteLine("\nDados atualizados:" + e);

            Console.WriteLine("\nDigite a quantidade de produtos para remover");
            qte = int.Parse(Console.ReadLine());
            e.RemoverProdutos(qte);
            Console.WriteLine("\nDados atualizados:" + e);

            Console.ReadLine();
        }
    }
}
