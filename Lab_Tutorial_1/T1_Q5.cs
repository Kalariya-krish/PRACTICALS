using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q5
    {
        public static void Main(String[] args)
        {
            // Defining variable
            int n, fact = 1;

            // Getting user input 
            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            n = Convert.ToInt32(str);

            // iterate loop up to n
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            // Display result
            Console.WriteLine("Factorial : {0}", fact);
            Console.Read();
        }
    }
}
