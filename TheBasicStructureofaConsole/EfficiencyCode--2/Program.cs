using System;

//make the Console class as Static and the you will not need to continouslly call it
using static System.Console;

namespace EfficiencyCode__2
{
    class Program
    {
        static void Main(string[] args)
        {
            SetConsoleTextColor(ConsoleColor.Blue);
            WriteLine("Hello World!");
            ResetConsoleColor();

            WriteLine("Please Enter your name");
            SetConsoleTextColor(ConsoleColor.Cyan);
            WriteLine($"Your name is {ReadLine()} ");
            ResetConsoleColor();

            SetConsoleTextColor(ConsoleColor.DarkYellow);
            WriteLine("Enter your Course");
            WriteLine($"You are pursuing  {ReadLine()}");
            ResetConsoleColor();
            
            //the write method
            SetConsoleTextColor(ConsoleColor.Magenta);
            WriteLine("What is your age : ");
            Write($"You Age is : {ReadLine()}");

            #region Other use cases for the Console class
            //Todo Take the console input and save them in Variables
            //Todo Type conversions of the variables 
            //Todo Everyone design a simple console application and make sure it build ones it does and then use Vsts

            #endregion
            ReadKey();
        }

        //A basic method to set the Console colour
        public static void SetConsoleTextColor(ConsoleColor color)
        {
            ForegroundColor = color;
        }

        public static void ResetConsoleColor()
        {
            ForegroundColor = ConsoleColor.White;
        }
    }
}
