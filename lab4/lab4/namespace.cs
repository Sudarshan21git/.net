using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
    public class student
    {
        int id;
        int roll;
        string name;

        public student(int eid,int r,string n)
        {
            id = eid;
            roll=r; 
            name = n;
        }
        public void display()
        {
            Console.WriteLine("the student id:" + id + "name:" + name + "roll:" + roll);
        }
    }
}
