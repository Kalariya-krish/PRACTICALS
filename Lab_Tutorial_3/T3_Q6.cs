using System;

namespace PRACTICALS.Lab_Tutorial_3
{
    internal class T3_Q6
    {
        class Line
        {
            private double length;
            public Line()
            {
                Console.WriteLine("Object is being created, length = 10");
                length = 10;
            }

            public void setLength(double len)
            {
                length = len;
            }

            public double getLength()
            {
                return length;
            }
        }

        class TestLine
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

                Line line = new Line();

                Console.WriteLine("Length of line : {0}", line.getLength());
                line.setLength(6);

                Console.WriteLine("Length of line : {0}", line.getLength());
                Console.ReadKey();
            }
        }
    }
}
