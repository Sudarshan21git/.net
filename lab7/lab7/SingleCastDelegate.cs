using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class SingleCastDelegate
    {
        public static int square(int x)
        {
            return x * x;
        }
        public delegate int sqdelegate(int x);
        static void Main(string[] args)
        {
            sqdelegate s= new sqdelegate(square);
            int res = s(5);
            Console.WriteLine("using single cast delegate");
            Console.WriteLine("square of two number:"+res);
            Console.ReadKey();
        }
    }
}
