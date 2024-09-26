using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Q4
    {
        public static void Main(string[] args)
        {
            int[] data = { 15, 3, 34, 45, 7, 89, 105, 20 };
            int sum = data.Sum();
            int min = data.Min();
            int max = data.Max();
            double avg = data.Average();
            int cnt = data.Count();
            Console.WriteLine("sum of element:" + sum);
            Console.WriteLine("min element:" + min);
            Console.WriteLine("max element:" + max);
            Console.WriteLine("avg element:" + avg);
            Console.WriteLine("count element:" + cnt);
            Console.ReadKey();

        }
    }
}