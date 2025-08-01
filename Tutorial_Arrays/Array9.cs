using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICALS.Tutorial_Arrays
{
    internal class Array9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
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
