using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q11
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter gender : ");
            string gender = Console.ReadLine();

            if(gender == "M" || gender == "m")
            {
                Console.WriteLine("Hello Mr. {0}", name);
            }
            else if (gender == "F" || gender == "f")
            {
                Console.WriteLine("Hello Ms. {0}", name);
            }
            else
            {
                Console.WriteLine("Please enter valid gender");
            }
            Console.Read();
        }
    }
}
