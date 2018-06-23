using System;

namespace moreSwichCase {

    class Program {
        ///When is switch case most applicable  and an if statement applicable
        //When checking for only one  if one value statisfies in the case.
        //There are may come a case where you are required to check on two codition if they are satisfied
        static void Main (string[] args) {

            //Console.WriteLine ("Hello World!");
            // string input = Console.ReadLine ();
            //makes the first letter uppercase
            // input = char.ToUpper (input[0]).ToString () + input.Substring (1, input.Length - 1);
            // Console.WriteLine ($"the value input is the following {input}");
            Console.WriteLine ("enter you username");
            string username = Console.ReadLine ();
            Console.WriteLine ("enter you password");
            string password = Console.ReadLine ();
            //check for only one codition
            switch (username) {
                case "Edd":
                    Console.WriteLine ("Hey Modelator!");
                    break;
                case "Josh":
                    Console.WriteLine ("hey admin");
                    break;
                default:
                    Console.WriteLine ("Hey guest");
                    break;
            }
          //multiple check we use the when keyword
          switch (username.ToLower()) {
                case "Edd" when password.Equals("abcd12"):
                    Console.WriteLine ("Hey Modelator!");
                    break;
                case "josh" when password.Equals("1234"):
                    Console.WriteLine ("hey admin");
                    break;
                default:
                    Console.WriteLine ("Hey guest");
                    break;
            }
            Console.ReadKey ();

        }
    }
}