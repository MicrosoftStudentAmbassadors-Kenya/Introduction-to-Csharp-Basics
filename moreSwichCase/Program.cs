using System;

namespace moreSwichCase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            string input=Console.ReadLine()??"edd";
            input=char.ToUpper(input[0]).ToString()+input.Substring(1,input.Length-1);
            Console.WriteLine($"the value input is the following {input}");
            Console.ReadKey();
    
        }
    }
}
