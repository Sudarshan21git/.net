using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Q6
    {
        public class lengthExcep : ApplicationException
        {
            public lengthExcep(string msg) : base(msg) { }
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                if (name.Length < 10)
                {
                    Console.WriteLine("Hello " + name);
                }
                else
                {
                    throw new lengthExcep("Name length more than 10!!");
                }
            }
            catch (lengthExcep ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("End of program."); Console.ReadKey(); }
        }
    }
}
