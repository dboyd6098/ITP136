namespace week8Project
{
    using System;
    using static System.Console;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "car 1", "car 2", "car 3", "car 4", "car 5" };
            string[] make = new string[5];
            string[] model = new string[5];
            double[] cost = new double[5];

            for (int x = 0; x < cars.Length; x++)
            {
                WriteLine("Enter the make for {0,5}", cars[x]);
                make[x] = ReadLine();

                WriteLine("Enter the model for {0,5}", cars[x]);
                model[x] = ReadLine();

                WriteLine("Enter the cost for {0,5}", cars[x]);
                cost[x] = Convert.ToDouble(ReadLine());
            }

            WriteLine();

            WriteLine("{0,10}{1,15}{2,13}{3,15}", "Car #", "Make", "Model", "Cost");

            for (int y = 0; y < cars.Length; y++)
            {
                WriteLine("{0,10}{1,15}{2,13}{3,15}", cars[y], make[y], model[y], cost[y].ToString("C"));
            }

            WriteLine();

            double m = cost.Max();

            int c = Array.IndexOf(cost, m);

            WriteLine(cars[c] + " is the most expensive car");

            ReadKey();
        }
    }
}