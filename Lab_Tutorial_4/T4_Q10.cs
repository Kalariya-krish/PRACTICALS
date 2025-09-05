using System;

namespace PRACTICALS.Lab_Tutorial_4
{
    class MyException : Exception
    {
        public MyException(string str) : base(str)
        {
            Console.WriteLine("User defined exception");
        }
    }

    internal class T4_Q10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            try
            {
                throw new MyException("my exception generated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }

            Console.WriteLine("LAST STATEMENT");

            Console.Read();
        }
    }
}
