using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q3
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            Console.Write("Enter the number of elements (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArray elements in reverse order:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Read();
        }
    }
}
