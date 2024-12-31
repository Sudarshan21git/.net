using System;

namespace q2_c
{
    public class Person
    {
        string name;
        public void setName(string n)
        {
            name = n;
        }
        public string getName()
        {
            return name;
        }
    }

    public class Student : Person
    {
        public int roll;
        public void setRoll(int r)
        {
            roll = r;
        }
        public int getRoll()
        {
            return roll;
        }
    }

    public class Employee : Person
    {
        public string address;
        public void setAddress(string a)
        {
            address = a;
        }
        public string getAddress()
        {
            return address;
        }
    }

    public class HierarchicalInheritance
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.setRoll(1);
            s.setName("sita");


            Employee e = new Employee();
            e.setName("ritu");
            e.setAddress("bkt");

            
            Console.WriteLine($"Employee Details: \n Name = {e.getName()}\n  address = {e.getAddress()}");
            Console.WriteLine($"\n Student Details: \n Name = {s.getName()}\n roll = {s.getRoll()}");

            Console.ReadKey();
        }
    }
}