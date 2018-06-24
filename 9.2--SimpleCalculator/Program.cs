using System;

namespace SimpleCalculator {
    class Program {
        static void Main (string[] args) {
            //Takes two inputs a and b 
            string firstNum, secondNum;

            //conversion parameters
            int convertedNum1, convertedNum2;

            Console.WriteLine ("Enter the first Number ");
            firstNum = Console.ReadLine ();
            Console.WriteLine ("Enter the second Number");
            secondNum = Console.ReadLine ();

            //convert the input to intergers
            //chouse the conversion type below couse they return true when suceesfull converted
            //return false when the conversions fails..therefore i can apply the check for numeric 
            //easily

            //on comment out  the following two lines to see the output
            //bool a=Int32.TryParse(firstNum,out convertedNum1);
            //Console.WriteLine(a);

         
            if (!Int32.TryParse (firstNum, out convertedNum1))
                Console.WriteLine ($"Please Enter numeric values. You entered {firstNum}");

            if (Int32.TryParse (secondNum, out convertedNum2))
                Console.WriteLine ("Please enter a numerical value..You entered {0}", secondNum);

            Console.WriteLine ("Hello World!");
        }
    }
}