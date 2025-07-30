using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q13
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            int a = 0,b = 1,next;
            Console.Write(a + " ");
            Console.Write(b + " ");

            for(int i=2; i<=10; i++)
            {
                next = a + b;
                Console.Write(next+" ");
                a = b;
                b = next;
            }

            Console.Read();
        }
    }
}
