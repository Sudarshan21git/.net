using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class stack
    {
        public static void Main()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Pop();
            s.Push(4);
            Console.WriteLine("Items in stack are ");
            foreach (int i in s)
                Console.Write(i +" ");
            Console.ReadKey();

        }
    }
}
