using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q10
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine("OUTPUT: " + masked);
            }
            else
            {
                Console.WriteLine("Invalid mobile number. Too short.");
            }

            Console.Read();

        }
    }
}
