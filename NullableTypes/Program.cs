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
            Console.WriteLine("undefined");

                Console.ReadKey ();
        }
    }
}