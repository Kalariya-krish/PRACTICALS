using System;

namespace PRACTICALS
{
    internal class swaping
    {
        public static void with3variable(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void without3variable(ref int a, ref int b)
        {
            a = a + b;  // 10 + 20 = 30
            b = a - b;  // 30 - 20 = 10
            a = a - b;  // 30 - 10 = 20
        }

        public static void Main(String[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Before Swapping: a = " + a + ", b = " + b);

            //with3variable(ref a, ref b);
            without3variable(ref a, ref b);
            Console.WriteLine("After Swapping: a = " + a + ", b = " + b);

            Console.Read();
        }
    }
}
