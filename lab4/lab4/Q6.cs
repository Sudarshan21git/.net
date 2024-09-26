using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab4
{
    public class Time
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public Time()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
           
        }



        public void DisplayTime()
        {
            Console.WriteLine($"{Hours:D2}:{Minutes:D2}:{Seconds:D2}");
        }

        public static Time Add(Time t1, Time t2)
        {
            int totalSeconds = (t1.Hours * 3600 + t1.Minutes * 60 + t1.Seconds) +
                               (t2.Hours * 3600 + t2.Minutes * 60 + t2.Seconds);

            return SecondsToTime(totalSeconds);
        }

        public static Time Subtract(Time t1, Time t2)
        {
            int totalSeconds1 = t1.Hours * 3600 + t1.Minutes * 60 + t1.Seconds;
            int totalSeconds2 = t2.Hours * 3600 + t2.Minutes * 60 + t2.Seconds;

            int diffSeconds = totalSeconds1 - totalSeconds2;

            if (diffSeconds < 0)
            {
                Console.WriteLine("Resulting time cannot be negative.");
                return new Time();
            }

            return SecondsToTime(diffSeconds);
        }

        private static Time SecondsToTime(int seconds)
        {
            Time time = new Time();
            time.Hours = seconds / 3600;
            seconds %= 3600;
            time.Minutes = seconds / 60;
            time.Seconds = seconds % 60;
            return time;
        }
    }

    internal class Program
    {
        static void Main()
        {

            Time time1 = new Time(3, 50, 45);
            Time time2 = new Time(1, 45, 30);

            Console.WriteLine("Time 1:");
            time1.DisplayTime();

            Console.WriteLine("Time 2:");
            time2.DisplayTime();

            Time addedTime = Time.Add(time1, time2);
            Console.WriteLine("Added Time:");
            addedTime.DisplayTime();

            Time subtractedTime = Time.Subtract(time1, time2);
            Console.WriteLine("Subtracted Time:");
            subtractedTime.DisplayTime();
            Console.ReadKey();
        }
    }
}
