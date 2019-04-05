using System;
using System.Collections.Generic;

namespace BadSuperBowlNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            startApp();
        }

        static void startApp()
        {
            Console.Title = "Roman Numerual Uno";
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;

            var convertor = new RomanNumeralConvertor();

            Console.WriteLine("Which Number Would You Like To Convert To Roman Numerals");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Solution: {convertor.ConvertToRoman(input)}");
            Console.WriteLine("Convert Another Number? (y/n)");

            var answer = Console.ReadLine().ToLower();
            if (answer != "y")
            {
                Environment.Exit(-1);
            }
            startApp();
        }
    }
}
