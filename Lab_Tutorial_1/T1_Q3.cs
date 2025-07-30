using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q3
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            Console.Write("Entre the number : ");
            int no = Convert.ToInt32(Console.ReadLine());
            if (no % 2 == 0)
            {
                Console.WriteLine(no+" is Even Number");
            }
            else
            {
                Console.WriteLine(no + " is Odd Number");
            }
            Console.Read();
        }
    }
}
