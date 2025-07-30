using System;
namespace PRACTICALS
{
    internal class outparam
    {
        /// <summary>
        ///     update method takes two out parameters. it updates the values of these parameters using out keyword.
        /// </summary>
        /// <param name="x">this is first variable</param>
        /// <param name="b">this is second variable</param>
        /// 
        /// 
        public static void update(out int x, out float b)
        {
            x = 100;
            b = 200.90f;
        }

        public static void Main(string[] args)
        {
            int x = 10;
            float y = 20.5f;

            Console.WriteLine("Before update: x = {0}, y = {1}", x,y);
            update(out x, out y);
            Console.WriteLine("After update: x = {0}, y = {1}", x, y);

            // Three difference between out and ref:
            // 1. Out parameters do not need to be initialized before being passed to the method.
            // 2. Out parameters must be assigned a value before the method returns.
            // 3. Out parameters can be used to return multiple values from a method.

        }
    }
}
