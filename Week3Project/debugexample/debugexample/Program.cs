// Program takes a hot dog order
// And determines price
using System;
using static System.Console;
class DebugFour1
{
    static void Main()
    {
        const double BasicDogPrice = 2.00;
        const double ChiliPrice = 0.69;
        const double CheesePrice = 0.49;
        String wantChili, wantCheese;
        double price;

        WriteLine("Do you want chili on your dog? ");
        wantChili = ReadLine();
        WriteLine("Do you want cheese on your dog? ");
        wantCheese = ReadLine();
        if (wantChili == "Yes" && wantCheese == "Yes")
        {
            price = BasicDogPrice + ChiliPrice + CheesePrice;
        }
        else if (wantCheese == "Yes")
        {
            price = BasicDogPrice + CheesePrice;
        }
        else if (wantChili == "Yes")
            price = BasicDogPrice + ChiliPrice;
        else
            price = BasicDogPrice;
        WriteLine("Your total is {0}", price.ToString("C"));
        ReadKey();
    }
}
