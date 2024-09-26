using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Q7
    {
        public static int mul(int x,int y = 7)
        {

        return x * y;
        }

        public static int sum(int m,int n = 5)
        {
            return m + n;
        }
        public static void Main(string[] args)
        {
            int res1 = mul(2);
            int res2 = sum(n:3,m:20);
            Console.WriteLine("the optional paramter is "+res1);
            Console.WriteLine("the named parameter is:" + res2);
            Console.ReadKey();

        }
    }
}
