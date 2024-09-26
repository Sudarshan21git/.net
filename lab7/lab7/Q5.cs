using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Q5
    {
        public class balanceExp : ApplicationException
        {
            public balanceExp(string msg) : base(msg) { }
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the balance and withdraw amout:");
                double balance = double.Parse(Console.ReadLine());
                double withdraw = double.Parse(Console.ReadLine());
                if (withdraw < balance)
                {
                    balance -= withdraw;
                    Console.WriteLine("Remaining balance=" + balance);
                }
                else
                {
                    throw new balanceExp("INSUFFICIENT BALANCE!!");
                }
            }
            catch (balanceExp ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("End of program.");
                Console.ReadKey(); }
        }
    }
}
