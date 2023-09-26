namespace week5Project
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

            WriteLine();

            FindArea();

            WriteLine();

            double rateOutput = LocalTaxRate();
            WriteLine("Your local tax rate is {0}", rateOutput);

            ReadKey();
        }

        static void WelcomeStatement()
        {
            WriteLine("Welcome to My Method Examples");
        }

        static void MagicNumber()
        {
            int secretNumber = 23;
            WriteLine("My favorite number is {0}", secretNumber);
        }

        static void FindArea()
        {
            double area;
            double num1;
            double num2;
            WriteLine("Enter a number for length");
            num1 = Convert.ToDouble(ReadLine());
            WriteLine();
            WriteLine("Enter another number for width");
            num2 = Convert.ToDouble(ReadLine());
            WriteLine();
            area = num1 * num2;
            WriteLine("The calculated area is {0}", area);
        }

        static double LocalTaxRate()
        {
            double rateInput;
            WriteLine("Enter a number for your local tax rate");
            rateInput = Convert.ToDouble(ReadLine());
            WriteLine();
            return rateInput;
        }
    }
}