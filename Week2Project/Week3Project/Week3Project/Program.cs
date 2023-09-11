namespace Week3Project

{
    using System;
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            int apptOption, ageInput, labInput;
            int childYes = 3;
            int adultYes = 4;
            int labInputYes = 5;
            int adultSickLabBill = 100;
            int childSickLabBill = 75;
            int childSickBill = 50;
            int adultSickBill = 75;
            int adultCheckBill = 100;
            int childCheckBill = 75;

            WriteLine("Please choose a reason for today's doctor visit.");
            WriteLine("1 - Sick Appointment, 2 - Check-up");
            apptOption = Convert.ToInt32(ReadLine());
            switch (apptOption)
            {
                case 1:
                    WriteLine("Was today's sick appointment for a child or an adult?  Please input 3 for child or 4 for adult.");
                    ageInput = Convert.ToInt32(ReadLine());
                    WriteLine("Did today's sick appointment include lab work?  Please input 5 for yes or 6 for no.");
                    labInput = Convert.ToInt32(ReadLine());

                    if (ageInput == childYes && labInput == labInputYes)
                    {
                        WriteLine("The total bill for today's sick appointment is {0}", childSickLabBill.ToString("C"));
                    }
                    else if (ageInput == adultYes && labInput == labInputYes) 
                    {
                        WriteLine("The total bill for today's sick appointment is {0}", adultSickLabBill.ToString("C"));
                    }
                    else if (ageInput == childYes)
                    {
                        WriteLine("The total bill for today's sick appointment is {0}", childSickBill.ToString("C"));
                    }
                    else if (ageInput == adultYes)
                    {
                        WriteLine("The total bill for today's sick appointment is {0}", adultSickBill.ToString("C"));
                    }
                    break;
                case 2:
                    WriteLine("Was today's check-up for a child or an adult?  Please input 3 for child or 4 for adult.");
                    ageInput = Convert.ToInt32(ReadLine());

                    if (ageInput == childYes)
                    {
                        WriteLine("The total bill for today's check-up is {0}", childCheckBill.ToString("C"));
                    }
                    else if (ageInput == adultYes)
                    {
                        WriteLine("The total bill for today's check-up is {0}", adultCheckBill.ToString("C"));
                    }
                    break;
                default:
                    WriteLine("You didn't select 1 or 2.");
                    break;
            }


            ReadKey();  
        }
    }
}