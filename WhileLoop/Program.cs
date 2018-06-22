using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1=2;
            //the following code creates an infinit loop
            while (num1<10) //conditon
            {
                Console.WriteLine("i will never end");
                num1++;
            }
            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
