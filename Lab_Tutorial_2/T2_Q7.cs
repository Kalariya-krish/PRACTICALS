using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q7
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            int[] arr = { 23, 34, 2, 45, 78, 90, 30 };
            
            Console.WriteLine("Even Numbers:");
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.Read();
        }
    }
}
