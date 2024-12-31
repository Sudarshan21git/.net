using System;

namespace q2_b { 
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

public class College : Student
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

public class MultiLevelInheritance
{
    public static void Main(string[] args)
    {
        College c = new College();
        c.setName("ritu");
        c.setRoll(1);
        c.setAddress("bkt");

        Console.WriteLine($"Name = {c.getName()}\n roll = {c.getRoll()}\n address = {c.getAddress()}");
        Console.ReadKey();
    }
}
}