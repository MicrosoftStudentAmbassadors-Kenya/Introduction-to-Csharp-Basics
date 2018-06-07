using System;
using Microsoft.Extensions.Configuration;

namespace Linqturorial
{
    class Program
    {
        public static IConfiguration configuration;
        static void Main(string[] args)
        {
            #region InitializationofNewObject
            string connectionstring = configuration.GetConnectionString("");
            var sequenc=new sequence();
            sequenc.startapp();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            sequenc.DefferedExecutions();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("Result showing Immidiate execution with linq");
            sequenc.ImmediateExecutions();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine("Result local Immidiate execution with linq");
            
            sequenc.localQueries();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            #endregion
            System.Console.WriteLine("This is awesome for visual studio code");
            sequenc.fluetSyntax();
            System.Console.WriteLine("l am testing the autosave feature and i will not save this line");
            
            Console.ReadKey();
        }
    }
}
