using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q9
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            string toggleCase = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                    toggleCase += char.ToLower(ch);
                else if (char.IsLower(ch))
                    toggleCase += char.ToUpper(ch);
                else
                    toggleCase += ch;
            }

            Console.WriteLine("OUTPUT: " + toggleCase);
            Console.Read();

        }
    }
}
