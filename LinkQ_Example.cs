using System;
using System.Linq;

namespace PRACTICALS
{
    internal class LinkQ_Example
    {
        public static void Main(String[] args)
        {
            int[] numbers = { 34, 87, 69, 094, 56, 2, 32};
            Console.WriteLine("Original array : " + string.Join(", ", numbers));

            //Console.WriteLine("Min element : " + numbers.Min());
            //Console.WriteLine("Max element : " + numbers.Max());
            Console.WriteLine("Sum of element : " + numbers.Sum());
            Console.WriteLine("Average : "+  numbers.Average());

            Array.Sort(numbers);
            Console.WriteLine("Sorted array : " + string.Join(", ", numbers));

            Array.Reverse(numbers);
            Console.WriteLine("Reversed array : " + string.Join(", ", numbers));


            int max = numbers[0];
            int min = numbers[0];
            foreach(int no in numbers)
            {
                if (no > max)
                    max = no;
                if (no < min)
                    min = no;
            }
            Console.WriteLine("Max element : " + max);
            Console.WriteLine("Min element : " + min);


            Console.Read();
        }
    }
}
