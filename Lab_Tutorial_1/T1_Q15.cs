using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q15
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter the no : ");
            int no = Convert.ToInt32(Console.ReadLine());
            int sum = 0, ono = no, digit;

            while (no != 0)
            {
                digit = no % 10;
                sum += (digit * digit * digit);
                no = no / 10;
            }

            if (sum == ono)
            {
                Console.WriteLine(ono + " Armstrong Number");
            }
            else
            {
                Console.WriteLine(ono + " Not an Armstrong Number");
            }
            Console.Read();
        }
    }
}
