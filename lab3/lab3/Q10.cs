using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3
{
    internal class Q10
    {


        public static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]
            {
                 {3, 2, 1},
                {1, 1, 2},
                {2, 1, 1}
            };

            int exp = 0;

            int i = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                exp = exp + matrix[i, j] * (matrix[i + 1, (j + 1) % 3] * matrix[i + 2, (j + 2) % 3] - matrix[i + 1, (j + 2) % 3] * matrix[i + 2, (j + 1) % 3]);
            }

            Console.WriteLine(exp);

            Console.ReadKey();


        }
    }
}
