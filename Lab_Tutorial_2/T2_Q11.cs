using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q11
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            Console.Write("Enter number of elements (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Sum of {0} elements = {1}", N, sum);

            Console.ReadLine();
        }
    }
}
