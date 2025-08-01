using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q6
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("You entered the following {0} command line arguments:",
               args.Length);

            for (int i = 0; i < args.Length; i++)         
            {                                           
                Console.WriteLine(args[i]);                
            }
        }
    }
}
