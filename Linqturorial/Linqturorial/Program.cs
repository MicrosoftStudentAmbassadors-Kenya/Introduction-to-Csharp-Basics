using System;
using Microsoft.Extensions.Configuration;
using static System.Console;

namespace Linqturorial
{
    class Program
    {
        public static IConfiguration configuration;
        static void Main(string[] args)
        {
            #region InitializationofNewObject
            string connectionstring = configuration.GetConnectionString("");        
            var sequence=new sequence();
            sequence.startapp();
            ForegroundColor = ConsoleColor.DarkGreen;
            sequence.DefferedExecutions();
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Result showing Immidiate execution with linq");
            sequence.ImmediateExecutions();
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("Result local Immidiate execution with linq");
            
            sequence.localQueries();
            ForegroundColor = ConsoleColor.DarkGreen;
            #endregion
            WriteLine("This is awesome for visual studio code");
            sequence.fluetSyntax();
            WriteLine("l am testing the autosave feature and i will not save this line");
            
            ReadKey();
        }
    }
}
