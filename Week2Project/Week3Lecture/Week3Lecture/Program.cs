namespace Week3Lecture
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            int first = 2;
            int second = 3;

            if (first == second)
            {
                WriteLine("First equals second");
            }
            else
            {
                if (first > second)
                {
                    WriteLine("first is greater than second");
                }
                else
                {
                    WriteLine("first is less than second");
                }
                WriteLine("First does not equal second");
            }


            char ch = 'i';

            if (ch == 'A' || ch == 'a')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'E' || ch == 'e')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'I' || ch == 'i')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'O' || ch == 'o')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'U' || ch == 'u')
            {
                WriteLine("Vowel");
            }
            else
            {
                WriteLine("Consonant");
            }



            int option, a, b, total;

            WriteLine("please enter your first number");
            a = Convert.ToInt32(ReadLine());

            WriteLine("please enter your second number");
            b = Convert.ToInt32(ReadLine());



            WriteLine("1 - add number, 2 - subtraction, 3 - multiply, 4 - divide");
            option = Convert.ToInt32(ReadLine());

            switch (option)
            {
                case 1:
                    total = (a + b);
                    WriteLine("your total is {0}", total);
                    break;
                case 2:
                    total = (a - b);
                    WriteLine("your total is {0}", total);
                    break;
                case 3:
                    total = (a * b);
                    WriteLine("your total is {0}", total);
                    break;
                case 4:
                    total = (a / b);
                    WriteLine("your total is {0}", total);
                    break;
                default:
                    WriteLine("YOU DIDNT SELECT 1 - 4");
                    break;
            }


        }
    }
}