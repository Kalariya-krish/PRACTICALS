using System;

namespace PRACTICALS.Lab_Tutorial_2
{
    internal class T2_Q5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");
            int[] arr = { 10, 20, 10, 30, 40, 20, 50, 30 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            count++;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Total number of duplicate elements: " + count);
            Console.Read();
        }
    }
}
