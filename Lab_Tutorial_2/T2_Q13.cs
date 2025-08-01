using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q13
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] denominations = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in denominations)
            {
                int count = amount / note;
                if (count > 0)
                {
                    Console.WriteLine("Notes of Rs.{0} = {1}", note, count);
                    amount %= note;
                }
            }

            Console.ReadLine();
        }
    }
}
