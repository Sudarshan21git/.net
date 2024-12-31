using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class queue
    {
        public static void Main()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Network");
            q.Enqueue("dotnet");
            q.Dequeue();
            q.Enqueue("java");
            Console.WriteLine("item at queue are ");
            foreach (var item in q) 
                Console.Write(item +" ");
            Console.ReadKey();
        }
    }
}
