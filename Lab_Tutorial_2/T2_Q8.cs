using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q8
    {
        public static void Main(string[] args)
        {
            int[] arr = { 12, 45, 3, 67, 23, 89, 34 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Array elements in descending order:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Read();
        }
    }
}
