using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q10
    {
        public static void Main(string[] args)
        {
            int[,] mat1 = { { 1, 2 }, { 3, 4 } };
            int[,] mat2 = { { 5, 6 }, { 7, 8 } };
            int[,] sum = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = mat1[i, j] + mat2[i, j];
                }
            }

            Console.WriteLine("Sum of the two matrices:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
