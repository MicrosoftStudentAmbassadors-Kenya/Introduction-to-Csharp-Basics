using System;
using System.Diagnostics;
using System.Globalization;
using static System.Console;

namespace SringInterpolationnEscapesequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //some valiable decalations
            double a, b;
            //valiable initialization
            a = 3;
            b = 4;
            ForegroundColor = ConsoleColor.DarkGreen;
            //using string interpolation to display are
            WriteLine($"Area of {a} and {b} is {a*b}");
            //assuming a,b are side of a tringle find the hypotenues.
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine($"the leght of the hypotenues of side {a} and {b}is given by :{Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2))}");
            WriteLine("Hello World!");
            WriteLine();
            //Specifiying and interpolated expressions
            var date =new DateTime(1731,11,25);
            WriteLine($"on {date:yyyy MMMM dd} We started learning c# together");

            //Control the widths and alignments of formatted interpolated expressions
            ForegroundColor = ConsoleColor.Yellow;
            const int NamedAlignments = -9;
            const int ValueAlignments = 7;
            WriteLine($"three classical pyhtogoream means of {a} and {b}");
            WriteLine($"|{"Arithimetic",NamedAlignments}|{0.5 * (a+b),ValueAlignments}");
            WriteLine($"|{"Geometric",NamedAlignments}|{Math.Sqrt(a*b),ValueAlignments}");
            WriteLine($"|{"Harmonic",NamedAlignments}|{2/(1/a+1/b),ValueAlignments}");

            string username = "Jane";
            string stringWithescape ="C:\\Users\\edd\\source\\repos\\Introduction-to-Csharp-Basicd\\Notes\\4--StringIntrpolation.md";
            var verbatismInterpolated =@"C:\Users\edd\source\repos\Introduction-to-Csharp-Basicd\Notes\4--StringIntrpolation.md";
            WriteLine(stringWithescape);
            WriteLine(verbatismInterpolated);
            ReadKey();

        }
    }
}
