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

            Console.ForegroundColor=
            Console.WriteLine("Please Enter your Name");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hello World!");

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
