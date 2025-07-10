using System;

namespace PRACTICALS
{
    internal class practice
    {
        public static void Main(String[] args)
        {

            // *** Array ****

            //Console.Write("Enter the size of the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] a = new int[5];
            //for (int i=0; i<a.Length; i++)
            //{
            //    Console.Write("Enter element {0} : ",i);
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach(int i in a)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();




            // *** Increment Operators ****

            //int a = 5;
            //int b = 5;
            //int res = a++ + ++b + ++b + ++a + ++a;
            //Console.WriteLine("Result: " + res);



            // *** Switch Case ****

            //int c = 2;
            //switch (c)
            //{
            //    case 1:
            //        Console.WriteLine("a = 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("a = 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("a = 3");
            //        break;
            //    default:
            //        Console.WriteLine("a is not 1,2,3");
            //        break;
            //}




            // *** Pattern Program ****

            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i =0; i <4; i++)
            //{
            //    for (int j=4; j>i; j--)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}


            for(int i=1; i<=9; i++)
            {
                int k = i;
                if (i > 5)
                {
                    k = 10 - i;
                }
                for (int j=1; j<=k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
