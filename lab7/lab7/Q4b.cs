using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Q4b
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5] { 1, 2, 3, 4, 5 };
                Console.WriteLine(arr[5]);

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
         
            }
            finally
            {
                Console.WriteLine("the end of program");
                Console.ReadKey();
            }
        }
    }
}
