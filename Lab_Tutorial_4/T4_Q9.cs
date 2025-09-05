using System;

namespace PRACTICALS.Lab_Tutorial_4
{
    internal class T4_Q9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            int x = 0;

            try
            {
                int div = 100 / x;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed: Program ended safely.");
            }

            Console.Read();
        }
    }
}
