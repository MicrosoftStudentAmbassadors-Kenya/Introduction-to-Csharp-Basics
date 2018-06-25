using System;
namespace Calculate {

    class Calculate {
        static void Main (string[] args) {
            
            //dont want the calcualotor to terminate..i will use an infinite loop

            while (true)
            {
                string inputNum1,inputNum2;
                double numOne=0, numTwo=0;

                bool isNumeric = false;
                do
                {
                ChangeTextColor(ConsoleColor.DarkMagenta);
                Console.WriteLine("Please enter the first number");
                inputNum1 = Console.ReadLine();
                Console.WriteLine("Please enter the second Nummber");
                inputNum2 = Console.ReadLine();
                try
                {
                    numOne = convertToDouble.Convert(inputNum1);
                    numTwo = convertToDouble.Convert(inputNum2);
                }
                catch (Exception e)
                {
                    isNumeric = true;
                    Console.WriteLine(e);
                    //throw new Exception("The number must be numeric");
                }   
                    Console.WriteLine ("What operation is required : add (+) ,subtract (-),Multiply (*),Modulus (%)? please indicate beloe");
                    var operation = Console.ReadLine ();
                    Console.Clear ();

                    var calcuate = CalculateEngine.Calcuate(operation, numOne, numTwo);
                    Console.WriteLine($"The {operation} of {numOne} and {numTwo} is {calcuate}");
                } while (isNumeric);
               




            }
            
          
        }

     static void ChangeTextColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        
    }

}