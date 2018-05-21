using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using  static  System.Console;
namespace BasicIOandVariables
{
    public class Program
    {
        //The entry point of the program

        /// <summary>
        /// c# language is type safe.
        /// since the default input type is a string we need to convert the value is
        /// we need another variable other than the string
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            WriteLine("***************Basic console I/O");
            //GetuserData();
            //VariableDeclaration();
           // VariableMultipleDecration();
            //VariableDefaults();
            //SizeofVariables();
            
            VariableConversions();


            //todo create some variabl to hold some data and the n use them 
        }

       
        private static void SizeofVariables()
        {
            WriteLine("size in terms of bits");
            WriteLine("The size of interger is {0}",sizeof(int));
            WriteLine("The size of character is {0}",sizeof(char));
            WriteLine("The size of long is {0}",sizeof(long));
            WriteLine("The size of decimal is {0}",sizeof(decimal));
            WriteLine("The size of double is {0}",sizeof(double));
        }


        private static void VariableDeclaration()
        {
            //inside a method local variable declared as
            // datatype varname;
            int myint;
            string mystring;
            
            //declaration and intialization
            int myint2 = 89;
            string name = "Edwin";
            



        }
 
        private static void VariableMultipleDecration()
        {
            WriteLine("=> Data Declaration:");
            int myint = 0;
            string mystring;
            
            //multiple decralation 
            bool b1 = true, b2 = true, b3 = b1;

        }
        
        private static void VariableDefaults()
        {
            int def = default;
            Console.WriteLine(def);
        }

        private static void GetuserData()
        {
          Write("Please enter your name");
            string userName = ReadLine();
            Write("please enter your age");
            string age = ReadLine();
            
            //change the color of the console
            ConsoleColor prvcolor = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            
            //echo the console
            WriteLine($"Hello {userName} You are {age} years old");
            //restore the previous color

            ForegroundColor = prvcolor;

        }
        private static void VariableConversions()
        {
            //variable declarations
            int num = 2;
            char two;
            //use the convert class to convert values
            two = Convert.ToChar(num);
            

        }

    }
}