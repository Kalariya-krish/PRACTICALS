using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q20
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            int count = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
