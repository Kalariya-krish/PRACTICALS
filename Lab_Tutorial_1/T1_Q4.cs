using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q4
    {
        static void Main(String[] args)
        {
            int x;
            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            x = Convert.ToInt32(str);
            if (x % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is Odd");
            Console.Read();
        }
    }
}
