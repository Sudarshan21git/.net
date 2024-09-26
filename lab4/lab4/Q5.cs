using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Q5
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee address: ");
            string address = Console.ReadLine();
            Console.Write("Enter employee phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter employee salary: ");
            float salary = float.Parse(Console.ReadLine());

            Company company = new Company(name, address, phone, salary);

            Console.WriteLine("Company employee Details:");
            Console.WriteLine("Name: " + company.Name);
            Console.WriteLine("Address: " + company.Address);
            Console.WriteLine("Phone: " + company.Phone);
            Console.WriteLine("Salary: " + company.Salary);
            Console.ReadKey();
        }
        public struct Company
        {
            public string Name;
            public string Address;
            public string Phone;
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
}
