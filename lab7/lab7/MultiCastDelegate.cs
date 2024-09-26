using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{ 
    internal class MultiCastDelegate
    {
        public static int square(int x)
        {

        return x * x; }

        public static int cube(int x)
        {
            return x * x * x;
        }
        public delegate int Multicastdelegate(int x);

        public static void Main(string[] args)
        {
          Multicastdelegate del=new Multicastdelegate(square);

            int sq=del(5);
            Console.WriteLine(" the square of two number:"+sq);
            del += cube;
            Console.WriteLine("the cube of two number:" + del(5));
            Console.ReadKey();
          
        }
    }
}
