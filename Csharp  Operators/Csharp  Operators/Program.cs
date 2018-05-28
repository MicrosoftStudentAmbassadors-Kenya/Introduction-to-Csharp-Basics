using System;
using System.Transactions;

namespace Csharp__Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Area of a rectangle
            Console.Title = "Area of Rectangle";
            int length, width, area;

            Console.WriteLine("Enter The length");
            //convert the string into an integer
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The width");
            //convert the string into an integer
            width = int.Parse(Console.ReadLine());

            Console.Clear();
            area = length * width;
            Console.WriteLine($"The area of the Rectangle is {area}cm^2");
            Console.ReadKey();

            //Area 
            
        }
    }
}
