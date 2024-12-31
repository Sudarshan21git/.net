using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class linkedlist
    {
        public static void Main()
        {
            LinkedList < double> ll = new LinkedList<double>();
            ll.AddLast(3.1);
            ll.AddFirst(1.1);
            ll.AddFirst(2.2);
            ll.RemoveFirst();
            Console.WriteLine("item at Linkedlist are ");
            foreach (double d in ll) 
                Console.Write(d +" ");
            Console.ReadKey();


        }
    }
}
