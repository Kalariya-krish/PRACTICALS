using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q6
    {
        public static void Main(String[] args)
        {
            int a, b, c, result;

            Console.Write("Enter Number 1: ");
            string str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2: ");
            string str2 = Console.ReadLine();
            b = Convert.ToInt32(str2);

            Console.Write("Enter Number 3: ");
            string str3 = Console.ReadLine();
            c = Convert.ToInt32(str3);

            result = Sum(a, b, c);
            Console.WriteLine("Sum : {0}",result);
            Console.Read();

        }
        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}
