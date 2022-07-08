using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_1___Enum__.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department (string name)
        {
            Name = name;
        }   

        public Department ()
        {

        }
    }
}
