using System;

namespace SimpleCalculator {
    class Program {

        static void Main (string[] args) {
            // and infinite loop----a loop that does not end 
            for (;;) {
                //Takes two inputs a and b 
                string firstNum, secondNum;

                //conversion parameters
                int convertedNum1, convertedNum2;
                bool isNumeric = false;
                do {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine ("Enter the first Number ");
                    firstNum = Console.ReadLine ();
                    Console.Clear ();
                    Console.WriteLine ("Enter the second Number");
                    secondNum = Console.ReadLine ();
                    Console.Clear ();

                    /*
                    convert the input to intergers
                    chouse the conversion type below couse they return true when suceesfull converted
                    return false when the conversions fails..therefore i can apply the check for numeric 
                    easily
                    */

                    //comment out  the following two lines to see the output
                    /*
                    bool a=Int32.TryParse(firstNum,out convertedNum1);
                    Console.WriteLine(a);
                    */

                    //    isNumeric = !Int32.TryParse (firstNum, out convertedNum1) ? false : true;
                    //    isNumeric=!Int32.TryParse(secondNum,out convertedNum2)?false:true;    
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (!Int32.TryParse (firstNum, out convertedNum1)) {
                        Console.WriteLine ($"Please Enter numeric values. You entered {firstNum}");
                        isNumeric = true;
                    } else {
                        isNumeric = false;
                    }

                    if (!Int32.TryParse (secondNum, out convertedNum2)) {
                        Console.WriteLine ("Please enter a numerical value..You entered {0}", secondNum);
                        isNumeric = true;
                    }

                } while (isNumeric);

                Console.WriteLine ("What operation is required : add (+) ,subtract (-),Multiply (*),Modulus (%)? please indicate beloe");
                var operation = Console.ReadLine ();
                Console.Clear ();

                /*make sure to make the comaparison Case insensitive for the words
            i am checking for the two comaparisons the i.e add (+) 
            i could enter the name add of the symbol +  either of the two,, add or +
            Remember for if statement we can combine two comparisons..applicable here
          
            for swich we compare one value to some possible casses--- could works to.
            */
                //you can use this format
                //  if(operation.ToLower()=="add")

                //but i prefer this..talk more about the methods 
                //the Equal methods takes in two parameters,,string beign comapared and the comaparison type
                //StringComparison.OrdinalIgnoreCase does comaparison letter by letter while ignoring the case
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (operation.Equals ("add", StringComparison.OrdinalIgnoreCase) || operation.Equals ("+")) {
                    Console.WriteLine ($"The addition of {convertedNum1} and {convertedNum2} is {convertedNum1+convertedNum2}");
                } else if (operation.Equals ("subtraction", StringComparison.OrdinalIgnoreCase) || operation.Equals ("-")) {
                    Console.WriteLine ($"The subtract of {convertedNum1} and {convertedNum2} is {convertedNum1-convertedNum2}");

                } else if (operation.Equals ("multiply", StringComparison.OrdinalIgnoreCase) || operation.Equals ("*")) {
                    Console.WriteLine ($"The multiplication of {convertedNum1} and {convertedNum2} is {convertedNum1*convertedNum2}");

                } else if (operation.Equals ("modulus", StringComparison.OrdinalIgnoreCase) || operation.Equals ("%")) {
                    Console.WriteLine ($"The modulus of {convertedNum1} and {convertedNum2} is {convertedNum1%convertedNum2}");

                } else {
                    //works like the default clause
                    Console.WriteLine ("Not in the list today");

                }

                // to implement a switch you could use the format below
                Console.WriteLine ("The switch implementation below!!! enjoy");
                switch (operation) {
                    case "add":
                    case "+":
                        Console.WriteLine ($"The addition of {convertedNum1} and {convertedNum2} is {convertedNum1+convertedNum2}");
                        break;
                    default:
                        Console.WriteLine ($"out of the operation of our calculator");
                        break;

                }
            }
        }
    }
}