using System;

namespace TheBasicStructureofaConsole
{
    /// <summary>
    /// different main method signature
    /// </summary>
    class Program
    {
        //Todo Create a console application using dotnetcore and dotnet standard
        static int Main(string[] args)
        {
            //Output method call
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("****This is my First C# application");
            Console.ForegroundColor = ConsoleColor.White;

          //  Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please Enter your Name",Console.ForegroundColor=ConsoleColor.DarkBlue);
            
            //Console.ReadLine() reads the String from the console
            Console.WriteLine($"Your name is  {Console.ReadLine()}",Console.BackgroundColor=ConsoleColor.Yellow);

            //Prints out the text to the console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter your Course");
            Console.WriteLine($"You are Pursuing { Console.ReadLine()}");
            Console.ForegroundColor = ConsoleColor.White;

            //observe the behaviour of the Console.Write method
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Please Enter Your Age");
            Console.Write($"Your age is {Console.ReadLine()}");

            Console.WriteLine("Please Enter your name");

            Console.WriteLine(Console.ReadLine());
            Console.ReadKey();
            return 0;
        }
        /*
        //no parameters and a return type
        static void Main()
        {

        }

        //int return type, no parameters
        static int Main()
        {
            return 0;
        }
        */
    }
}
