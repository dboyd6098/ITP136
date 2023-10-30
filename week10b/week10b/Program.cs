namespace week10b
{
    using System;
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            List<CakeOrder> orders = new List<CakeOrder>();
            WriteLine("Welcome to the Cake Stop!");

            char moreItems = 'y';
            int counter = 0;

            while (moreItems == 'y')
            {
                WriteLine("Let's get the design and decoration for order {0}", counter + 1);

                collectCakeOrder(ref orders);
                counter++;
                WriteLine("Wold you like to proceed? y/n");
                moreItems = Convert.ToChar(ReadLine());
            }

            WriteLine("{0,-15}{1,-20}{2,-20}", "Name", "Decoration", "Design");

            foreach (CakeOrder o in orders)
            {
                WriteLine("{0,-15}{1,-20}{2,-20}", o.OrderName, o.OrderDesign, o.OrderDecoration);
            }

            ReadKey();
           
        }

        public static void collectCakeOrder(ref List<CakeOrder> o)
        {
            var listOfDesigns = File.ReadLines("Design.csv").Select(line => new Designs(line)).ToList();
            var listOfDecorations = File.ReadLines("Decorations.csv").Select(line => new Decorations(line)).ToList();

            Write("Name for this Order Item: ");
            String name = ReadLine();

            WriteLine("Which Design would you like: ");

            foreach (Designs des in listOfDesigns)
            {
                WriteLine($"{des.DesignID}\t{des.DesignName}");
            }

            int a = Convert.ToInt32(ReadLine());
            string design = listOfDesigns[a - 1].DesignName;

            WriteLine("Which Decoration would you like: ");

            foreach (Decorations dec in listOfDecorations)
            {
                WriteLine($"{dec.DecorationID}\t{dec.DecorationName}");
            }

            int b = Convert.ToInt32(ReadLine());
            string decoration = listOfDecorations[b - 1].DecorationName;

            o.Add(new CakeOrder(name, design, decoration));

        }
    }
}