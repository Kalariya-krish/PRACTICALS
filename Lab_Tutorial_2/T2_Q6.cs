using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q6
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            int[] arr = { 23, 34, 2, 45, 78, 90 };
            int maximum = arr[0];
            int minimum = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }
            }

            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Minimum: " + minimum);
            Console.Read();
        }
    }
}
