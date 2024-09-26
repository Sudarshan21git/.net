using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Q2
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("the max is:"+max);
            Console.WriteLine("the min value is" + min);
            Console.ReadKey();
            }
       
    }
}
