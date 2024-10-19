using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_calculator_kata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator Kata");
            Console.WriteLine("Enter an expression to calculate or q to quit:");

            //while loop to keep loopiong until user quits
            while (true)
            {
                //read the expression from the user
                string expression = Console.ReadLine();
                //check if the user wants to quit
                if (expression == "q")
                {
                    break;
                }
                //calculate the result
                try
                {
                    int result = Calculator.Calculate(expression);
                    Console.WriteLine("Result: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
