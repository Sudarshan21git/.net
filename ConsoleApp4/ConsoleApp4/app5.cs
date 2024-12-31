using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class app5
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter salary: ");
            float salary = float.Parse(Console.ReadLine());

            Company company = new Company(name, address, phone, salary);
            Console.WriteLine();
            Console.WriteLine("Company Details:");
            Console.WriteLine(company.Name);
            Console.WriteLine(company.Address);
            Console.WriteLine(company.Phone);
            Console.WriteLine(company.Salary);
            //Console.ReadKey();
        }
    }
        public struct Company
        {
            public string Name, Address, Phone;
            public float Salary;

            public Company(string name, string address, string phone, float salary)
            {
                Name = name;
                Address = address;
                Phone = phone;
                Salary = salary;
            }
        }
    
}
