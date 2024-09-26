using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Q4a
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the first number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the second number:");
                int num2 = int.Parse(Console.ReadLine());
                int div = num1 / num2;
                Console.WriteLine("the division of two num: " + div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("end the program");
                Console.ReadKey();
            }
        }
    }
}
