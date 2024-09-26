using System;

namespace lab3
{
    internal class Q4
    {
        public static void Main(string[] args)
        {
            int[,] num1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] num2 = { { 4, 5, 6 }, { 7, 8, 9 }, { 1, 2, 3 } };
            int[,] mul = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mul[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        mul[i, j] += num1[i, k] * num2[k, j];
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mul[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
