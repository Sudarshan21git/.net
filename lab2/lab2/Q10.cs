using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q10
    {
        public static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("Enter the number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("number\tcube");

        again:
            if (count <= a)
            {
                int cube = count * count * count;
                Console.WriteLine(count + "\t" + cube);
                count++;
                goto again;
            }

            Console.ReadKey();
        }
    }
}
