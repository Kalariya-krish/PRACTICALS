using System;

namespace PRACTICALS.Lab_Tutorial_4
{
    class StaticVar
    {
        public static int num;

        // Constructor increments static variable
        public StaticVar()
        {
            num++;
        }

        // Method to return num
        public static int getNum()
        {
            return num;
        }
    }

    internal class T4_Q4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            StaticVar s3 = new StaticVar();

            Console.WriteLine("Variable num: {0}", StaticVar.getNum());

            Console.Read();
        }
    }
}
