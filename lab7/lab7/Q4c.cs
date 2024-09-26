using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Q4c
    {
        public static void Main(string[] args)
        {
            try
            {
                object obj = 5;
                int n = (short)obj;
                Console.WriteLine(n);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("End"); }
            Console.ReadKey();
        }
    }
}
