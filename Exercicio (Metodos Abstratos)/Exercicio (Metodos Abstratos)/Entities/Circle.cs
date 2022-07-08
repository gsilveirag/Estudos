using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio__Metodos_Abstratos_.Entities.Enum;

namespace Exercicio__Metodos_Abstratos_.Entities
{
    internal  class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle (Color color, double radius) : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
