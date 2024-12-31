using System;

public class Counter
{
    private int value;

    // Constructor
    public Counter(int value)
    {
        this.value = value;
    }

    // Overloading the prefix ++ operator
    public static Counter operator ++(Counter c)
    {
        c.value++;
        return c;
    }

    // Overloading the prefix -- operator
    public static Counter operator --(Counter c)
    {
        c.value--;
        return c;
    }

    // Method to display the value
    public void Display()
    {
        Console.WriteLine("Value: " + value);
    }
}

public class Pract
{
    public static void Main()
    {
        Counter count = new Counter(5);

        // Using prefix increment
        ++count;
        count.Display();  // Output: Value: 6

        // Using postfix increment
        count++;
        count.Display();  // Output: Value: 7

        // Using prefix decrement
        --count;
        count.Display();  // Output: Value: 6

        // Using postfix decrement
        count--;
        count.Display();  // Output: Value: 5
    }
}
