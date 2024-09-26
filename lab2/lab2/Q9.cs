using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q9
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int a = 0;
            do
            {
                Console.WriteLine("Enter a number:");
                int x = int.Parse(Console.ReadLine());
                a = x;
                if (x >= 0)
                {
                    sum += x;
                }
            } while (a > 0);
            Console.WriteLine("The sum of the numbers is:" + sum);
            Console.ReadKey();
        }
    }
}
