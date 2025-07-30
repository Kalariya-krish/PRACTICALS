using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q4
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            int[] original = { 78, 23, 34, 5, 90 };
            int[] copy = new int[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
            Console.WriteLine("Original Array Elements:");
            for (int i = 0; i < original.Length; i++)
            {
                Console.Write(original[i] + " ");
            }
            Console.WriteLine("\nCopied Array Elements:");
            for (int i = 0; i < copy.Length; i++)
            {
                Console.Write(copy[i] + " ");
            }
            Console.Read();
        }
    }
}
