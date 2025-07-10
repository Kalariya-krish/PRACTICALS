using System;

namespace PRACTICALS.Lab_Tutorial_1
{
    internal class T1_Q14
    {
        public static void Main(String[] args)
        {
            string[] s = new string[100];
            int digit;
            int index = 0;

            Console.Write("Enter the number : ");
            int no = Convert.ToInt32(Console.ReadLine());

            while (no != 0)
            {
                digit = no % 10;
                switch (digit)
                {
                    case 0:
                        s[index++] = "Zero";
                        break;
                    case 1:
                        s[index++] = "One";
                        break;
                    case 2:
                        s[index++] = "Two";
                        break;
                    case 3:
                        s[index++] = "Three";
                        break;
                    case 4:
                        s[index++] = "Four";
                        break;
                    case 5:
                        s[index++] = "Five";
                        break;
                    case 6:
                        s[index++] = "Six";
                        break;
                    case 7:
                        s[index++] = "Seven";
                        break;
                    case 8:
                        s[index++] = "Eight";
                        break;
                    case 9:
                        s[index++] = "Nine";
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                no = no / 10;
            }


            Console.Write("In words: ");
            for (int i = index - 1; i >= 0; i--)
            {
                Console.Write(s[i] + " ");
            }
            Console.Read();
        }
    }
}
