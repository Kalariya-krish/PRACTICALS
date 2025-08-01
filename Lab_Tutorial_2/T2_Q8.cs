using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    class NumberManipulator2
    {
        public int getValues(out int x, out int y, out int z)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third value: ");
            z = Convert.ToInt32(Console.ReadLine());

            int sum = x + y + z;
            return sum;
        }
    }

    internal class T2_Q8
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            NumberManipulator2 n = new NumberManipulator2();

            int a, b, c, sum;

            sum = n.getValues(out a, out b, out c);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.WriteLine("After method call, value of c : {0}", c);
            Console.WriteLine("Sum : {0}", sum);

            Console.ReadLine();
        }
    }
}
