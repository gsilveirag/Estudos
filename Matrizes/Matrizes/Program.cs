using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            
            Console.WriteLine("Linhas:");
            M = int.Parse(Console.ReadLine());

            Console.WriteLine("Colunas");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {

                string[] Valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(Valores[j]);   
                }
            }

            Console.WriteLine("Digite um numero:");
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == X)
                    {
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }

                        if (i > 0)
                        {

                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }

                        if (j < N - 1)
                        {

                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }

                        if (i < M - 1)
                        {

                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                        // solução paliativa para parar de varrer a matriz:

                        j = N;
                        i = M;
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
