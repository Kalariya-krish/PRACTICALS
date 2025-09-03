using System;

namespace PRACTICALS.Lab_Tutorial_3
{
    internal class T3_Q5
    {
        class Product
        {
            string pcode;
            string pname;
            string mname;

            public Product(string pcd, string pnm, string mnm)
            {
                pcode = pcd;
                pname = pnm;
                mname = mnm;
            }

            public void Display()
            {
                Console.WriteLine("\nProduct Code:= " + pcode);
                Console.WriteLine("Product Name:= " + pname);
                Console.WriteLine("Manufacturer Name:= " + mname);
            }
        }

        public class TestProduct
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

                int n = args.Length;

                if (n < 3)
                {
                    Console.WriteLine("Syntax Error\n");
                    Console.WriteLine("Must Have THREE Arguments\n");
                    Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");
                }
                else
                {
                    string pcd = args[0];
                    string pnm = args[1];
                    string mnm = args[2];

                    Product p = new Product(pcd, pnm, mnm);

                    p.Display();

                    Console.Read();
                }
            }
        }
    }
}
