using System;

namespace DatesCalcApp_Lab1p2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter today in mm/dd/yyyy format:");
            DateTime Today = DateTime.Parse(Console.ReadLine());
            double subDouble = DateTime.Now.Ticks - Today.Ticks;


            Console.WriteLine("Enter Date 2 in mm/dd/yyyy format:");
            DateTime Date2 = DateTime.Parse(Console.ReadLine());
            double subDouble2 = DateTime.Now.Ticks - Today.Ticks;

            TimeSpan difference = Date2.Subtract(Today);
            
            Console.WriteLine(difference.Days + "--Days");
            Console.WriteLine(difference.Days * 24 + "--Hours");
            Console.WriteLine(difference.Days * 24 * 60 + "--Minutes");
            Console.WriteLine(difference.Days / 30 + "--Months");
            Console.WriteLine(difference.Days / 365 + "--Years");
            Console.ReadLine();
        }
    }
}
