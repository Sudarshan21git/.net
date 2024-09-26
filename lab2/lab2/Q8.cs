using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2

{
    internal class Q8
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());

            int first = 0, sec = 1, next = 0;
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                    next = i;

                else
                {
                    next = first + sec;
                    first = sec;
                    sec = next;

                }

            }
            if (n > 0)
            {
                Console.WriteLine("The " + n + "th term of fibonacci series is " + next);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();  
        }
    }
}
