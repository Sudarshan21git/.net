using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Q3
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        sum += arr[i, j];
                }
            }
            Console.WriteLine("sum of diagonal element is:" + sum);
            Console.ReadLine();
        }
    }
}