using System;

namespace ConsoleApp4
{
    public class Time
    {
        public int Hours, Minutes, Seconds;
        public Time()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public Time(int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
            
        }
        public void display()
        {
            Console.WriteLine($"{Hours:D2}:{Minutes:D2}:{Seconds:D2}");
        }
        private static Time SecondsToTime(int seconds)
        {
            Time t = new Time();
            t.Hours = seconds / 3600;
            seconds %= 3600;
            t.Minutes = seconds / 60;
            t.Seconds = seconds % 60;
            return t;
        }

        public static Time Add(Time t1, Time t2)
        {
            int totalSec = (t1.Hours * 3600 + t1.Minutes * 60 + t1.Seconds) +
                               (t2.Hours * 3600 + t2.Minutes * 60 + t2.Seconds);

            return SecondsToTime(totalSec);
        }

        public static Time Subtract(Time t1, Time t2)
        {
            int s1 = t1.Hours * 3600 + t1.Minutes * 60 + t1.Seconds;
            int s2 = t2.Hours * 3600 + t2.Minutes * 60 + t2.Seconds;

            int diffSec = s1 - s2;

            if (diffSec < 0)
            {
                Console.WriteLine("Time cannot be negative.");
                return new Time(); 
            }

            return SecondsToTime(diffSec);
        }

        
    }

    public class app6
    {
        static void Main()
        {
            Time t1 = new Time(3, 40, 3);
            Time t2 = new Time(1, 30, 4);

            Console.Write("Time 1 :");
            t1.display();

            Console.Write("Time 2 :");
            t2.display();

            Time add = Time.Add(t1, t2);
            Console.Write("added time:");
            add.display();

            Time sub = Time.Subtract(t1, t2);
            Console.Write("subtracted Time:");
            sub.display();
        }
    }
}
