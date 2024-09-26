using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Q5
    {
        public static void Main(string[] args)
        {
            int[][] num = new int[3][];
            num[0] = new int[4] {1, 2, 3,4};
            num[1] = new int[2] { 5, 6 };
            num[2] = new int[3] { 7, 8 ,9};

            Console.WriteLine("jagged array:");
            for (int i = 0; i <num.Length; i++)
            {
                for(int j = 0; j < num[i].Length; j++)
                {
                    Console.Write(num[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
