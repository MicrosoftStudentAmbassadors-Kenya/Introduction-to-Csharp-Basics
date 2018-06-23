using System;

namespace NullableTypes {
    class Program {
        static void Main (string[] args) {

            //possible nullable types
            int? i = 10;
            double? di = 3.14;
            bool? flag = null;
            char? letter = 'a';
            //There are nullable arrays
            int?[] arr = new int?[10];

            int? num = null;
            //is the HasValue Property true
            if (num.HasValue)
                Console.WriteLine ($"num = " + num.HasValue);
            else
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine ("num = null");

            //y is set to Zero
            int y = num.GetValueOrDefault ();
            try {
                y = num.Value;
            } catch (InvalidOperationException e) {

                Console.WriteLine (e.Message);

            }
            Console.WriteLine ("Hello World!");

            if (i.HasValue)
                Console.WriteLine (i.Value);
            else
                Console.WriteLine ("undefined");

            int? x = 3;
            int ex;

            //a try block is used to catch Exeption thrown
            try {
                // ex=x; does not compile
                ex = (int) x;
            } catch (Exception e) {
                Console.WriteLine (e.Message + "the of the Explicit conversion of the nullable type to non-nullable");

            }

            Console.WriteLine ($"Compile successsfully {x.Value}");
            // Be keen on the comparisons below
            int? num1 = 10;
            int? num2 = null;
            if (num1 >= num2) {
                Console.WriteLine ("num1 is greater than or equal to num2");
            } else {
                // This clause is selected, but num1 is not less than num2.
                Console.WriteLine ("num1 >= num2 returned false (but num1 < num2 also is false)");
            }
            if (num1 < num2) {
                Console.WriteLine ("num1 is less than num2");
            } else {
                // The else clause is selected again, but num1 is not greater than
                // or equal to num2.
                Console.WriteLine ("num1 < num2 returned false (but num1 >= num2 also is false)");
            }
            if (num1 != num2) {
                // This comparison is true, num1 and num2 are not equal.
                Console.WriteLine ("Finally, num1 != num2 returns true!");
            }
            // Change the value of num1, so that both num1 and num2 are null.
            num1 = null;
            if (num1 == num2) {
                // The equality comparison returns true when both operands are null.
                Console.WriteLine ("num1 == num2 returns true when the value of each is null");
            }
            Console.ReadKey ();
        }
    }
}