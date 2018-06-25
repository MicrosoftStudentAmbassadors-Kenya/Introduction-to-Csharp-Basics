using System;

namespace Calculate
{
   public class CalculateEngine
    {
        public static double Calcuate(string operation, double firstNumber, double secondNumber)
        {
            double result;
            switch (operation)
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "subtract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "multiply":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "modulus":
                case "%":
                    result = firstNumber % secondNumber;
                    break; 
                case "divide":
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                   throw new InvalidOperationException("specified operation not recognised");
                    break;     
                 
            }

            return result;
        }
    }
}