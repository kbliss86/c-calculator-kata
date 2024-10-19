using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_calculator_kata
{
    public class Calculator
    {
        //method to calculate simple arithmetic expressions passed by a string
        public static int Calculate(string expression)
        {
            //check for empty expression
            if (string.IsNullOrEmpty(expression))
            {
                throw new ArgumentException("Expression is empty");
            }
            //handle single number directly
            if (int.TryParse(expression, out int number))
            {
                return number;
            }
            //split the number based oin space, trim each part and parse numbers/operators
            string[] parts = expression.Split(' ');
            if (parts.Length < 3 || parts.Length % 2 == 0)
            {
                throw new ArgumentException("Expression is not in the correct format");
            }
            //initialize the result with the first number
            number = int.Parse(parts[0]);
            //loop through the remaining parts to evaluate the expression
            for (int i = 1; i < parts.Length; i += 2)
            {
                //parse the next number
                int nextNumber = int.Parse(parts[i + 1]);
                //evaluate the expression
                switch (parts[i])
                {
                    case "+":
                        number += nextNumber;
                        break;
                    case "-":
                        number -= nextNumber;
                        break;
                    case "*":
                        number *= nextNumber;
                        break;
                    case "/":
                        number /= nextNumber;
                        break;
                    default:
                        throw new ArgumentException("Invalid operator");
                }
            }
            return number;

        }
    }
}
