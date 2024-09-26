using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class anonymousmethod
    {
        public delegate int adddelegate(int x , int y);

        public static void Main(string[] args)
        {
            adddelegate add = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine("addition of two num:"+add(5,2));
            Console.ReadKey();
        }
    }
}
