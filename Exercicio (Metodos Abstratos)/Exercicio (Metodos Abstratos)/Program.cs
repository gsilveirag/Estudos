using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio__Metodos_Abstratos_.Entities;
using Exercicio__Metodos_Abstratos_.Entities.Enum;

namespace Exercicio__Metodos_Abstratos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Retangle or Circle (r/c)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red");
                Enum.TryParse(Console.ReadLine(), out Color color);
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double heigth = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(color, width, heigth));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }




        }
    }
}
