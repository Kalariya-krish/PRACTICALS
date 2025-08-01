using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q4
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            Console.Write("Enter first number (A): ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number (B): ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- Arithmetic Operators ---");
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"A * B = {A * B}");
            Console.WriteLine($"A / B = {A / B}");
            Console.WriteLine($"A % B = {A % B}");

            Console.WriteLine("\n--- Data Type Demonstration ---");

            float f = A / 2.5f;
            double d = B * 1.234;
            decimal dec = 12345.6789m;
            char ch = 'C';
            string name = "CSharp";
            bool isEqual = A == B;

            Console.WriteLine($"Float: {f}");
            Console.WriteLine($"Double: {d}");
            Console.WriteLine($"Decimal: {dec}");
            Console.WriteLine($"Char: {ch}");
            Console.WriteLine($"String: {name}");
            Console.WriteLine($"Boolean: {isEqual}");

            Console.Read();
        }
    }
}
