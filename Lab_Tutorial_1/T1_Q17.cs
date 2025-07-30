using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q17
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            for (int i=1; i<5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
