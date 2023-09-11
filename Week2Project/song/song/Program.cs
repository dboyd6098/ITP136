using System;
using static System.Console;

namespace song
{
    class Program
    {
        static void Main(string[] args)
        {
            string song;
            Console.WriteLine("What is your song?");
            song = Console.ReadLine();
            Console.WriteLine("Your song is {0}", song);
            ReadKey();
        }
    }
}