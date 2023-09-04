using System;

namespace WeekTwo
{
    using static System.Console;

    class program
    {
        static void Main(string[] args)
        {
            
            int num1 = 5;
            double num3 = 5.1;

            string firstName = "Dave";
            char middleInit = 'G';

            int num4, num5, num6;

            const string lastName = "Boyd";

            double a, b, c;

            double total;

            string inputString;

            Console.WriteLine("Enter your first number");
            inputString = Console.ReadLine();

            a = Convert.ToDouble(inputString);

            Console.WriteLine("Enter your second number");
            inputString = Console.ReadLine();

            b = Convert.ToDouble(inputString);

            Console.WriteLine("Enter your third number");
            inputString = Console.ReadLine();

            c = Convert.ToDouble(inputString);

            total = (a + b + c) / 3;

            Console.WriteLine("Your average is {0}", total.ToString("C"));

            Console.WriteLine("Your numbers are {0,5},{1,5}{2,10}", a, b, c);

            Console.ReadKey();


        }


    }

}

