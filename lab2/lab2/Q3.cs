using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input a number 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("input a number 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("input a number 3: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("largest no. is:" + a);
                }
                else
                {

                    Console.WriteLine("largest no. is: " + c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("largest no. is: " + b);
                }
                else { Console.WriteLine("the largest no is:" + c); }
            }
            
            Console.ReadKey();

        }
    }
}
