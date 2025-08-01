using System;
namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q12
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            Console.Write("Enter number of elements in array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the element to search: ");
            int x = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");

            Console.ReadLine();
        }
    }
}
