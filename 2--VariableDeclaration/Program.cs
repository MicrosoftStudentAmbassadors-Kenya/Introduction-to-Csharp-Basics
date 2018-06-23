using System;

namespace CodingExpressionsandStatements
{
    class Program
    {/// <summary>
     ///There are a number of data types is c#
     /// bool -> hold Boolean values ie True or false
     /// byte  ->8-bit unsigned interger
     /// char   ->16 bit character
     /// decimal  ->128 bit precise decimal
     /// double   ->64 bit precise floationg point
     /// float     ->32 bit precise floating point 
     /// int       -32 bit signed interger
     /// long      -64 bit signed interger
     /// sbyte     -8 bit signed type
     /// short     -16 bit signed type
     /// uint      -32 bit unsigned interger
     /// ulong      -64 bit unsigned interger
     /// ushort     -16 bit unsigned
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            //to define a variable you use the format
            // datatype variblename

            
            //variable declaration
            int age;
            
            //multiline declaration
            string course, name, uni;
            
            //variable initialization
            uni = "Dedan Kimathi university";

            Console.WriteLine(uni);
            
            //let know take input from the console
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter you age");
            
            //type conversion
             age=Int32.Parse(Console.ReadLine());
            
            //second conversion
            Console.WriteLine("Enter your favorite number");
            var age2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please Enter the course ");
            course = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine($"your name is {name} and you are of age {age} and you and in {uni} pursuing" +
                              $"{course}");
            Console.WriteLine("Hello World!");
        }
    }
}