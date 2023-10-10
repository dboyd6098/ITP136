namespace week6Lecture
{
    using System;
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Daniel Airlines");
            WriteLine();
            WriteLine("Please enter your first and last name");
            
            string name = ReadLine();
            
            WriteLine();
            WriteLine("Please enter your address including city, state, and zip code");
            
            string address = ReadLine();
            
            WriteLine();
            WriteLine("Please enter your travel date in format 00/00/0000");
            
            string travelDate = ReadLine();

            double bagTotalAmount = BagData();
            double seatTotalAmount = SeatData();

            double subTotal = bagTotalAmount + seatTotalAmount;
            double taxTotal = subTotal * 5 / 100;
            double grandTotal = subTotal + taxTotal;

            WriteLine();
            WriteLine("Name: {0}", name);
            WriteLine("Address: {0}", address);
            WriteLine("Travel Date: {0}", travelDate);
            WriteLine();
            WriteLine("Subtotal {0}", subTotal.ToString("C"));
            WriteLine("Tax {0}", taxTotal.ToString("C"));
            WriteLine("Grand Total {0}", grandTotal.ToString("C"));
            
        }
        static double BagData()
        {
            WriteLine();
            int bagNumber;
            double calculatedBagAmount;
            string bagDecision;
            string yes = "yes";
            int noBags = 0;

            WriteLine("Will you be checking any bags for this flight?  Please enter yes or no");
            bagDecision = ReadLine();
            WriteLine();
            if (bagDecision == yes)
            {
                WriteLine("Please enter the total number of bags you will be checking in for this flight");
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
            string seatDecision;
            string yes = "yes";
            int noSeats = 0;

            WriteLine("Would you like to request any seats for this flight?  Please enter yes or no");
            seatDecision = ReadLine();
            WriteLine();
            if (seatDecision == yes)
            {
                WriteLine("Please enter the total number of seats you would like to request for this flight");
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