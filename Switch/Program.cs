using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day for today");
            var input = Console.ReadLine();
            input=input.ToLower();
            DayOfWeek day = DayOfWeek.Friday;
            if (input == "monday")
            {
                day = DayOfWeek.Monday;
            }
            else if (input == "teusday")
            {
                day = DayOfWeek.Tuesday;
            }
            else if (input == "wenesday")
            {
                day = DayOfWeek.Wednesday;
            }
            else if (input == "thursday")
            {
                day = DayOfWeek.Thursday;
            }
            else if (input == "friday")
            {
                day = DayOfWeek.Friday;
            }
            switch (day)
            {
                case DayOfWeek.Monday:
                  Console.ForegroundColor=ConsoleColor.Black;
                    Console.WriteLine($"Today is on {input} and its the first day of the week  ");
                    break;
                case DayOfWeek.Tuesday:
                  Console.ForegroundColor=ConsoleColor.Yellow;
                    Console.WriteLine("Today is on {input} and its the second day of the week");
                    break;
                case DayOfWeek.Wednesday:
                Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine($"today is on {input} and its on the third day of the week");
                    break;
                case DayOfWeek.Thursday:
                Console.ForegroundColor=ConsoleColor.DarkMagenta;
                    Console.WriteLine("today is on the fourth day of the week");
                    break;
                case DayOfWeek.Friday:
                Console.ForegroundColor=ConsoleColor.Gray;
                    Console.WriteLine($"today is on {input} and its the awesome day  ");
                    break;
                default:
                Console.ForegroundColor=ConsoleColor.DarkRed;
                    Console.WriteLine($"{input} is not a day..try again");
                    break;
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }
    }
}
