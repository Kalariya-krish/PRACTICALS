using System;

namespace PRACTICALS.Lab_Tutorial_2
{

    internal class T2_Q9
    {
        static void FindNumbers(int[] arr)
        {
            int xor = 0;

            foreach (int num in arr)
            {
                xor ^= num;
            }

            int rightmostSetBit = xor & (-xor);
            int num1 = 0, num2 = 0;

            foreach (int num in arr)
            {
                if ((num & rightmostSetBit) == 0)
                    num1 ^= num;
                else
                    num2 ^= num;
            }

            if (num1 < num2)
                Console.WriteLine($"{num1} {num2}");
            else
                Console.WriteLine($"{num2} {num1}");
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            int[] arr1 = { 1, 2, 3, 2, 1, 4 };
            FindNumbers(arr1);

            int[] arr2 = { 2, 1, 3, 2 };
            FindNumbers(arr2);

            Console.Read();
        }
    }
}
