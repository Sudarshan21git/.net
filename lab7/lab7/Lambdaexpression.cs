using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Lambdaexpression
    {
        public delegate int add(int a,int b);
        public delegate int sub(int a,int b);
        public static void Main(string[] args)
        {
            add ad = (a, b) =>(a + b);
            sub s= (a,b) =>(a - b);
            int res = ad(5, 6);
            int res1=s(5, 6);
            Console.WriteLine("additon of two number:"+res);
            Console.WriteLine("subtraction of two number:" + res1);
            Console.ReadKey();
        }
    }
}
