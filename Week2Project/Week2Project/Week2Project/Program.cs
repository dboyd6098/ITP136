using System;

namespace Week2Project
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            double oil, tires, inspection, subTotal, tax, grandTotal;
            
            string inputString;
          

            WriteLine("Welcome to the Auto Repair Calculator.");
           
            WriteLine("What is the cost for the oil change?");
            inputString = Console.ReadLine();

            oil = Convert.ToDouble(inputString);

            WriteLine("What is the cost for tires?");
            inputString = Console.ReadLine();

            tires = Convert.ToDouble(inputString);

            WriteLine("What is the cost for this inpsection?");
            inputString = Console.ReadLine();

            inspection = Convert.ToDouble(inputString);

            subTotal = oil + tires + inspection;

            WriteLine("The subtotal for this bill is {0}", subTotal.ToString("C"));

            tax = subTotal * 6 / 100;

            WriteLine("The tax for this bill is {0}", tax.ToString("C"));

            grandTotal = subTotal + tax;

            WriteLine("The grand total of this bill is {0}", grandTotal.ToString("C"));
      

        
         
        }
    }
}