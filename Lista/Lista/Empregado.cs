using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Empregado
    {
       public int Id { get;private set; }
       public string Name { get; set; }    
       
       public double Salario { get;private set; }  

        public Empregado(int id, string name, double salario)
        {
            this.Id = id;
            this.Name = name;
            this.Salario = salario;
        }
        public void aumentarSalario(double porcentagem)
        {
            Salario = porcentagem * Salario / 100.0 + Salario;
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salario;
        }
    }
}
