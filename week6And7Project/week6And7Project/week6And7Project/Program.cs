namespace week6And7Project
{
    using System;
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Reynolds Airline");
            WriteLine();
            WriteLine("Enter your first and last name");

            string name = ReadLine();

            WriteLine();

            WriteLine("Enter your street address including apartment number/letter");

            string streetAddress = ReadLine();

            WriteLine();

            WriteLine("Enter your city");

            string city = ReadLine();

            WriteLine();

            WriteLine("Enter your State");

            string state = ReadLine();

            WriteLine();    

            WriteLine("Enter your zip code");

            string zipCode = ReadLine();

            WriteLine();
            WriteLine("Enter your travel date in format 00/00/0000");

            string travelDate = ReadLine();

            double bagTotalAmount = BagData();
            double seatTotalAmount = SeatData();

            double subTotal = bagTotalAmount + seatTotalAmount;
            double taxTotal = subTotal * 5 / 100;
            double grandTotal = subTotal + taxTotal;

            WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("************************************Receipt************************************");
            WriteLine();
            WriteLine("Name: {0}", name);
            WriteLine("Address: {0}, {1}, {2} {3}", streetAddress, city, state, zipCode);
            WriteLine("Travel Date: {0}", travelDate);
            WriteLine();
            WriteLine("Subtotal: {0}", subTotal.ToString("C"));
            WriteLine("Tax: {0}", taxTotal.ToString("C"));
            WriteLine("Grand Total: {0}", grandTotal.ToString("C"));
            WriteLine();
            WriteLine("************************************Receipt************************************");


            Console.ResetColor();

        }
        static double BagData()
        {
            WriteLine();
            int bagNumber;
            double calculatedBagAmount;
            string bagDecisionInput;
            string bagDecisionLower; //holds bagDecisionInput value converted to lowercase for boolean evaluation
            string yes = "yes";
            int noBags = 0;

            WriteLine("Will you be checking any bags for this flight?  Enter yes or no");
            bagDecisionInput = ReadLine();
            bagDecisionLower = bagDecisionInput.ToLower();
            WriteLine();
            if (bagDecisionLower == yes)
            {
                WriteLine("Enter the total number of bags you will be checking in for this flight");
                bagNumber = Convert.ToInt32(ReadLine());
                calculatedBagAmount = bagNumber * 25;
                return calculatedBagAmount;
            }
            else
            {
                return noBags;
            }

        }
        static double SeatData()
        {
            WriteLine();
            int seatNumber;
            double calculatedSeatAmount;
            string seatDecisionInput;
            string seatDecisionLower; //holds seatDecisionInput value converted to lowercase for boolean evaluation
            string yes = "yes";
            int noSeats = 0;

            WriteLine("Would you like to request any seats for this flight?  Enter yes or no");
            seatDecisionInput = ReadLine();
            seatDecisionLower = seatDecisionInput.ToLower();
            WriteLine();
            if (seatDecisionLower == yes)
            {
                WriteLine("Enter the total number of seats you would like to request for this flight");
                seatNumber = Convert.ToInt32(ReadLine());
                calculatedSeatAmount = seatNumber * 30;
                return calculatedSeatAmount;
            }
            else
            {
                return noSeats;
            }
            ReadKey();
        }
    }
}