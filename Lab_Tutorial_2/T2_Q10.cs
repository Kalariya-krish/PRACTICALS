using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q10
    {
        public static int matSearch(int[,] mat, int N, int M, int X)
        {
            int i = 0, j = M - 1;

            while (i < N && j >= 0)
            {
                if (mat[i, j] == X)
                    return 1;
                else if (mat[i, j] > X)
                    j--;
                else
                    i++;
            }

            return 0;
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            int[,] mat1 = {
            { 3, 30, 38 },
            { 44, 52, 54 },
            { 57, 60, 69 }
                };

            int result1 = matSearch(mat1, 3, 3, 62);
            Console.WriteLine(result1);

            int[,] mat2 = {
            { 18, 21, 27, 38, 55, 67 }
        };

            int result2 = matSearch(mat2, 1, 6, 55);
            Console.WriteLine(result2);

            Console.Read();
        }
    }
}
