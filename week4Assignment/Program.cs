namespace week4Assignment
{
    using System;
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new Food();
            Food food2 = new Food();

            food1.FoodId = 1;
            food1.Name = "Asparagus";
            food1.Description = "Green, spear-like vegetable";
            food1.Cost = 3.99;

            food2.FoodId = 2;
            food2.Name = "Mackerel";
            food2.Description = "Small, oily fish";
            food2.Cost = 4.99;

            WriteLine("{0,2} {1,10} {2,20} {3,25}", "FoodID", "Name", "Description", "Cost");
            WriteLine("{0,1} {1,20} {2,31} {3,9}", food1.FoodId, food1.Name, food1.Description, food1.Cost);
            WriteLine("{0,1} {1,19} {2,21} {3,20}", food2.FoodId, food2.Name, food2.Description, food2.Cost);

            ReadKey();

        }

    }
}