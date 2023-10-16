namespace week8Assignment2
{
    using System;
    using static System.Console;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Stephens", "Jordan", "Gretzky" };
            double[] quiz = new double[3];
            double[] test = new double[3];
            double[] assignment = new double[3];


            for (int x = 0; x < names.Length; x++)
            {
                WriteLine("Enter a quiz for {0,10}", names[x]);
                quiz[x] = Convert.ToDouble(ReadLine());

                WriteLine("Enter a test for {0,10}", names[x]);
                test[x] = Convert.ToDouble(ReadLine());

                WriteLine("Enter a assignment for {0,10}", names[x]);
                assignment[x] = Convert.ToDouble(ReadLine());
            }

            WriteLine("{0,15}{1,20}{2,10}{3,10}", "Name", "Quiz", "Test", "Assignment");

            for (int y = 0; y < names.Length; y++)
            {
                
                WriteLine("{0,15}{1,20}{2,10}{3,10}", names[y], quiz[y], test[y], assignment[y]);

            }

            int i = 0;

            foreach (var name in names)
            {
                

                double avg;

                avg = ((quiz[i] + test[i] + assignment[i]) / 3);

                WriteLine("{0,10}{1,15}", name, avg.ToString("F2"));

                i++;
            }

            double m = quiz.Max();

            int p = Array.IndexOf(quiz, m);

            WriteLine(names[p] + " has the highest quiz grade");


            Array.Sort(names);

            WriteLine(names[0] + ", " + names[1] + ", " + names[2]);





        }
    }
}