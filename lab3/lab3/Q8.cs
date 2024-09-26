using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Q8

    {
        public static int add(int a, params int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            sum += a;
            return sum;
        }
        public static void Main(string[] args)
        {
            int result=add(1, 2, 3);
            Console.WriteLine("result is:"+result);
            Console.ReadKey();
        }
    }
}
