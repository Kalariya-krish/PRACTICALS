using System;

namespace PRACTICALS.Lab_Tutorial_3
{
    internal class T3_Q2
    {
        class Clock
        {
            private int hour;
            private int min;
            private int sec;

            public Clock()
            {
                hour = 12;
                min = 0;
                sec = 0;
            }

            public Clock(int hour, int min, int sec)
            {
                this.hour = (hour >= 0 && hour < 24) ? hour : 0;
                this.min = (min >= 0 && min < 60) ? min : 0;
                this.sec = (sec >= 0 && sec < 60) ? sec : 0;
            }

            public void IncrementSecond()
            {
                sec++;
                if (sec == 60)
                {
                    sec = 0;
                    min++;
                    if (min == 60)
                    {
                        min = 0;
                        hour++;
                        if (hour == 24)
                            hour = 0;
                    }
                }
            }

            public void DisplayTime()
            {
                Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
            }

            public int GetHour()
            {
                return hour;
            }

            public int GetMinute()
            {
                return min;
            }

            public int GetSeconds()
            {
                return sec;
            }
        }

        class Demo
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

                Clock clock1 = new Clock();
                Console.WriteLine("Clock 1 (default):");
                clock1.DisplayTime();

                clock1.IncrementSecond();
                clock1.IncrementSecond();
                Console.WriteLine("After increment:");
                clock1.DisplayTime();

                Clock clock2 = new Clock(23, 59, 58);
                Console.WriteLine("\nClock 2 (initialized with 23:59:58):");
                clock2.DisplayTime();

                clock2.IncrementSecond();
                clock2.DisplayTime();
                clock2.IncrementSecond();
                clock2.DisplayTime();

                Console.WriteLine($"\nClock 2 -> Hour: {clock2.GetHour()}, Minute: {clock2.GetMinute()}, Seconds: {clock2.GetSeconds()}");

                Console.Read();
            }
        }
    }
}
