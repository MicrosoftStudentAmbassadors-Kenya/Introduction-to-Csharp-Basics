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

            //Area of inner width in both cm and metres given tha the area of path is 450.575m^2  (ans  11.56m)
            //           _____________________________
            //          |   ___________20.65m______   |
            //          |  |                       |  |
            //          |  |                       |  |
            //          |  Y                       |  18.24m
            //          |  |                       |  |
            //          |  |                       |  |
            //          |  |_______________________|  |
            //          |____________37.79m___________|

            Console.Title = "Area of path";
            double largeArea, smallArea, remainder, y;

            //Calculate the areas
            largeArea = 37 * 18;
            smallArea = 18.24 * 37.79 - 450.575;

            //compute the width in cm
            y = (smallArea / 20.65)*100;

            //compute the measurement in both cm and m
            var wholeNo = (y / 100);
            remainder = y % 100;

            //Answer
            Console.WriteLine($"{wholeNo:N0}m {remainder:N0}cm");
        }
    }
}
