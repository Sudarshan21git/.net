// Write a C3 program to implement concept of following type of inheritance
//a. single level inheritance
//b. multi level inheritance
//c. hierarchical level inheritance
//d. multiple inheritance using interface

using System;
using System.Security.Cryptography;

namespace q2_a { 
public class Person {
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

public class Student : Person {
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

public class SingleLevelInheritance
{
    public static void Main(string[] args)
    {
        Student s = new Student();
        s.setRoll(1);
        s.setName("ritu");

        Console.WriteLine($"Name of student is {s.getName()} and roll is {s.getRoll()}" );
        Console.ReadKey();
    }
}
}
