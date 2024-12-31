using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class app
    {
        public static void Main(string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } };
            int[,] b = { { 1,3, 2 }, { 1,3, 4 } };
            int[,] m = new int[2, 3];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    m[i, j] = 0;
                    for (int k = 0; j < b.GetLength(0); k++)
                    {
                        m[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }

    }
}
