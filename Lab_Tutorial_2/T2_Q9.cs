using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q9
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int n = arr.Length;

            Console.WriteLine("Original Array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\nEnter position to delete (1 to {0}): ", n);
            int pos = Convert.ToInt32(Console.ReadLine());

            if (pos < 1 || pos > n)
            {
                Console.WriteLine("Invalid position!");
            }
            else
            {
                for (int i = pos - 1; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                n--;

                Console.WriteLine("\nArray after deletion:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.Read();
        }
    }
}
