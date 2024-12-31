using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// to demonstrate following type of generic class
// a. List<T>
namespace lab6
{
    public class list
    {
        public static void Main()
        {
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.RemoveAt(0);
            
            Console.WriteLine("Total no. of list item = " + l.Count);
            Console.ReadKey();
        }
    }
}
