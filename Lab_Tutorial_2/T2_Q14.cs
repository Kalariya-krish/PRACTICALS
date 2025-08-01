using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q14
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            Console.Write("Input the marks obtained in Maths: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int totalAll = maths + physics + chemistry;
            int totalMathsPhysics = maths + physics;

            if (maths >= 65 && physics >= 55 && chemistry >= 50 &&
                (totalAll >= 180 || totalMathsPhysics >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }

            Console.ReadLine();
        }
    }
}
