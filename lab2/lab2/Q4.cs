//write a c# program to read any digits (0-9) and display in respective word using switch case statement.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Q4

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The any number:");
            int n= int.Parse(Console.ReadLine());
            switch (n)
            {
            case 0: Console.WriteLine("The given number is zero");
                    break;
                    case 1: Console.WriteLine("The given number is One");
                    break;
                    case 2: Console.WriteLine("The given number is Two");
                    break;
                    case 3: Console.WriteLine("The given number is Three");
                    break;
                    case 4: Console.WriteLine("The given number is Four");
                    break;
                    case 5: Console.WriteLine("The given number is Five");
                    break;
                    case 6: Console.WriteLine("The given number is Six");
                    break;
                    case 7: Console.WriteLine("The given number is Seven");
                    break;
                    case 8: Console.WriteLine("The given number is Eight");
                    break;
                    case 9: Console.WriteLine("The given number is Nine");
                    break;
                    case 10: Console.WriteLine("The given number is Ten");
                    break;
                    default: Console.WriteLine("The given number is invaild");
                    break;
            }
            Console.ReadKey();
        }
    }
}
