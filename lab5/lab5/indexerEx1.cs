using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class employees
    {
        private int eid;
        private string name;
        private double salary;

        public object this[int index]
        {
            set
            {
                if (index == 0)
                    eid = (int)value;
                else if (index == 1)
                    name = (string)value;
                else if (index == 2)
                    salary = (double)value;

            }
            get
            {
                if (index == 0)
                    return eid;
                else if (index == 1)
                    return name;
                else if (index == 2)
                    return salary;
                else
                    return null;
            }
        }
    }

    internal class indexerEx1
    {
        public static void Main(string[] args)
        {
            employees e1 = new employees();
            e1[0] = 102;
            e1[1] = "sudarshan";
            e1[2] = 40000.00;
            Console.WriteLine("employee eid:" + e1[0]);
            Console.WriteLine("employee name:" + e1[1]);
            Console.WriteLine("employee campus:" + e1[2]);
            Console.ReadKey();

        }
    }
}