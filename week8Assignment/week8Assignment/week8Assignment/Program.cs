namespace week8Assignment
{
    using System;
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Stephens", "Boyd", "Billiams", "Willie" };

            //WriteLine(names[1]);

            for (int x = 0; x < names.Length; x++)
            {
                WriteLine(names[x]);
            }

            int[] nums = { 2, 13, 8, 9 };

            double[] price = { 12.25, 5.28, 6.13, 22.25 };

            for (int x = 0; x < nums.Length; x++)
            {
                WriteLine(nums[x]);
            }

            for (int x = 0; x < price.Length; x++)
            {
                WriteLine(price[x]);
            }

            for (int x = 0; x < names.Length; x++)
            {
                WriteLine("{0,10}{1,10}{2,10}", names[x], price[x], nums[x]);
            }

            ReadKey();
        }
    }
}