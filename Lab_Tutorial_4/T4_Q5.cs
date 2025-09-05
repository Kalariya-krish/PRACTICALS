using System;
namespace PRACTICALS.Lab_Tutorial_4
{
    public class O
    {
        public O(int value)
        {
            Console.WriteLine("Base constructor A()");
        }
    }

    public class P : O
    {
        public P(int value) : base(value)
        {
            Console.WriteLine("Derived constructor B()");
        }
    }

    internal class T4_Q5
    {
        static void Main()
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            O o = new O(0);
            P p = new P(1);

            Console.Read();
        }
    }
}
