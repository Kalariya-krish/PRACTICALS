using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q9
    {
        public static void Main(String[] args)
        {

            Console.Write("Enter your name : ");
            string str = Console.ReadLine();

            Console.WriteLine("Output : " + str.ToLowerInvariant());
            Console.Read();
        }
    }
}
