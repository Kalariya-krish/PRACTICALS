using System;

namespace PRACTICALS.Lab_Tutorial_4
{
    sealed class A
    {
        public int x;
        public int y;
    }
    class B
    {
        public int z;
    }
    internal class T4_Q7
    {
        static void Main()
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            A sc = new A();
            sc.x = 110;
            sc.y = 150;

            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);

            Console.Read();
        }
    }
}
