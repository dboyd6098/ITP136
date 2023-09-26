namespace week5ProjectVersion2
{
    using System;
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {

            WelcomeStatement();

            WriteLine();

            MagicNumber();
            int favoriteNumber = MagicNumber();
            WriteLine("My favorite number is {0}", favoriteNumber);

            WriteLine();

            double calculatedArea = FindArea();
            WriteLine("The calculated area is {0}", calculatedArea);

            WriteLine();

            double rateOutput = LocalTaxRate();
            WriteLine();
            WriteLine("Your local tax rate is {0}", rateOutput);


            ReadKey();
        }

        static void WelcomeStatement()
        {
            WriteLine("Welcome to My Method Examples");
        }

        static int MagicNumber()
        {
            int secretNumber = 23;
            return secretNumber;
        }

        static double FindArea()
        {
            Double area;
            Double num1;
            Double num2;
            WriteLine("Enter a number for length");
            num1 = Convert.ToDouble(ReadLine());
            WriteLine();
            WriteLine("Enter another number for width");
            num2 = Convert.ToDouble(ReadLine());
            WriteLine();
            area = num1 * num2;
            return area;
        }

        static double LocalTaxRate()
        {
            double rate;
            WriteLine("Enter a number for your local tax rate");
            rate = Convert.ToDouble(ReadLine());
            return rate;
        }
    }
}