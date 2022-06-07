using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Lista_2
{
    internal class Funcionario
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public double Salario { get; set; }

        public Funcionario (int id, string name, double salario)
        {
            this.Id = id;
            this.Name = name;
            this.Salario = salario;
        }

        public void AumentodeSalario (double porcentagem)
        {
            Salario = porcentagem * Salario / 100.0 + Salario;
        }
        public override string ToString()
        {
            return Id
                +", Funcionario: "
                + Name
                + " , R$"
                + Salario;
        }
    }
}
