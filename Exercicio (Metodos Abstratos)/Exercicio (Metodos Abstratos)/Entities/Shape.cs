using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio__Metodos_Abstratos_.Entities.Enum;

namespace Exercicio__Metodos_Abstratos_.Entities
{
    internal abstract class Shape
    {
       public Color Color { get; set; }

       public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
       
    }
}
