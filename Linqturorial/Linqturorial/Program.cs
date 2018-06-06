using System;
using Microsoft.Extensions.Configuration;

namespace Linqturorial
{
    class Program
    {
        public static IConfiguration configuration;
        static void Main(string[] args)
        {
            string connectionstring = configuration.GetConnectionString("");
            var sequenc=new sequence();
            sequenc.startapp();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            sequenc.DefferedExecutions();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            sequenc.ImmediateExecutions();


            Console.ReadKey();
        }
    }
}
