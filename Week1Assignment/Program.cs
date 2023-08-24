using System;

namespace WeekOne
{
    using static System.Console;

    class program
    {
        static void Main(string[] args)
        {
            WriteLine("Who is being seen today?");
            string patientName = ReadLine();
            WriteLine("Welcome: " + patientName);
            ReadKey();

        }


    }

}

