using System;

namespace PRACTICALS.Lab_Tutorial_4
{
    abstract class Test
    {
        protected int a;

        public abstract void A();
    }

    class Example1 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example1.A");
            a++;
            Console.WriteLine("Value of a: " + a);
        }
    }

    class Example2 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example2.A");
            a--;
            Console.WriteLine("Value of a: " + a);
        }
    }

    internal class T4_Q6
    {
        static void Main()
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            Test test1 = new Example1();
            test1.A();

            Test test2 = new Example2();
            test2.A();

            Console.Read();
        }
    }
}
