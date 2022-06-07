using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendizado2
{
    internal class Estoque
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;   
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;   
        }

        public override string ToString()
        {
            return "Produto:"
                + Nome
                + ", Preco:$"
                + Preco.ToString("F2")
                + " , Quatidade:"
                + Quantidade
                + " Total:$ "
                + ValorTotalEmEstoque().ToString("F2");
        }

    }
}
