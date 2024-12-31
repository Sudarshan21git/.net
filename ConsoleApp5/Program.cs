// write a c# program to illustrate the concept of abstract class and method 

using System;

public abstract class Shape
{
    public double dim1, dim2;
    public Shape(double dim1, double dim2)
    {
        this.dim1 = dim1;
        this.dim2 = dim2;
    }
    public abstract double area();

}

public class Rectangle : Shape
{
    public Rectangle(double l, double h) : base(l, h)
    {

    }
    public override double area()
    {
        return dim1 * dim2;

    }
}

public class abstractEx
{
    public static void Main(string[] args)
    {
        Rectangle t1 = new Rectangle(4, 5);
        double a = t1.area();
        Console.WriteLine("Area of Rectangle is " + a);
        Console.ReadKey();
    }

}
