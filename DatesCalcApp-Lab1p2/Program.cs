using System;

namespace DatesCalcApp_Lab1p2
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime Today = DateTime.Parse(GetUserInput());
            double subDouble = DateTime.Now.Ticks - Today.Ticks;


            DateTime Date2 = DateTime.Parse(GetUserInput());
            double subDouble2 = DateTime.Now.Ticks - Today.Ticks;

            TimeSpan difference = Date2.Subtract(Today);
            
            Console.WriteLine(difference.Days + "--Days");
            Console.WriteLine(difference.Days * 24 + "--Hours");
            Console.WriteLine(difference.Days * 24 * 60 + "--Minutes");
            Console.WriteLine(difference.Days / 30 + "--Months");
            Console.WriteLine(difference.Days / 365 + "--Years");
            Console.ReadLine();
        }

        static string GetUserInput()
        {
            Console.Write("Enter date: ");

            string input = string.Empty;

            while (string.IsNullOrWhiteSpace(input))
            {
                input = Console.ReadLine();

                if (input.Length == 0)
                {
                    Console.Write("Enter date: ");
                }

                if (!IsValidUserInput(input))
                {
                    Console.Write("Invalid input.");
                    Console.Write("Enter date: ");
                    input = string.Empty;
                }
            }

            return input;
        }

        static bool IsValidUserInput(string input)
        {
            return DateTime.TryParse(input, out var date);
        }
    }
}
