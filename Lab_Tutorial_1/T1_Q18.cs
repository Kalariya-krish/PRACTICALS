using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q18
    {
        public static void Main(String[] args)
        {
            int count = 1;
            for(int i=1; i<5; i++)
            {
                for(int j=1; j<=i; j++)
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
