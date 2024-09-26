
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class Employee
    {
        public int eid;
        public string name, address;
        public Employee(int eid, string name, string address)
        {
            this.eid = eid;

            this.name = name;
            this.address = address;

        }
    }
    internal class Q2
    {
        public static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee(49, "Sudarshan", "ktm"));
            elist.Add(new Employee(40, "Rosn", "pkr"));
            elist.Add(new Employee(5, "Rajan", "kirtipur"));
            elist.Add(new Employee(50, "Ujjwal", "ktm"));
            elist.Add(new Employee(21, "Sijan", "kirtipur"));
            Console.WriteLine("Employee  in descending order:");
            var res = elist.OrderByDescending(e => e.name);
            foreach (Employee emp in res)
            {
                Console.WriteLine("eid"+" "+ emp.eid + "  " + "name"+" "+ emp.name + " " + "address" +" "+ emp.address + " ");

            }
            Console.ReadKey();
        }
    }
}
