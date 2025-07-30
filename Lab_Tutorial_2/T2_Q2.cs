using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted array in ascending order:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.Read();
        }
    }
}
