using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Q9
    {


        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 12, 15 };

            foreach (int i in arr)
            {
                int flag = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                    }
                }

                if (flag == 2)
                {
                    Console.WriteLine(i + " ");
                }

                flag = 0;
            }
            Console.ReadKey();
        }
    }
}
