using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q19
    {
        public static void Main(String[] args)
        {
            for(int i=1; i<5; i++)
            {
                for(int j=5; j>i; j--)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
