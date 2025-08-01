using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICALS.Tutorial_Arrays
{
    internal class Array7
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            int[] arr = { 23, 34, 2, 45, 78, 90, 30 };

            Console.WriteLine("Even Numbers:");
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.Read();
        }
    }
}
