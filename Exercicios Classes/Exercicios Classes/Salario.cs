using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Classes
{
    internal class Salario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto= SalarioBruto + (SalarioBruto * porcentagem /100);
        }

        public override string ToString()
        {
            return "Funcionario: " 
                + Nome
                +", Salario Bruto: $"
                + SalarioLiquido().ToString("F2")
                + " Imposto Pago: $"
                + Imposto.ToString("F2");
        }
    }
}
