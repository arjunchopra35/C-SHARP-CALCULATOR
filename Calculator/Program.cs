/*Author: Arjun Chopra
 * Date: September 17, 2018
 * Program Name: Console Calculator
 * Program Description - A simple arithmatic console calculator
 * 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Title displayed at the top
            Console.Title = "Ice 3 - Console Calculator";

            // Constants
            const string add = "add";
            const string sub = "sub";
            const string mult = "mult";
            const string div = "div";

            // Variables
            double firstNumber;     //1st Input number
            double secondNumber;    //2nd Input number
            string operation;       //add, sub, mult, div
            bool isValidNumber;      //If input is a valid number true/false
            double result;          //Result of the Calculation

            // Prompt for the first number
            Console.Write("Enter the first number: ");
            // Tries to convert from string to double
            isValidNumber = double.TryParse(Console.ReadLine(), out firstNumber);
            //if not a number, write an error message
            if(!isValidNumber)
            {
                //Display the error message
                Console.WriteLine("Invalid First Number. ");
                //Prompt for any key to exit 
                Console.WriteLine("\nPress sny key to exit...");
                Console.ReadKey();
                return; //Terminate the Main() returning void
            }


            // Prompt for the second number
            Console.Write("Enter the second number: ");
            // Tries to convert from string to double
            isValidNumber = double.TryParse(Console.ReadLine(), out secondNumber);
            //if not a number, write an error message
            if (!isValidNumber)
            {
                //Display the error message
                Console.WriteLine("Invalid second Number. "+"\n\n");
                //Prompt for any key to exit 
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
                return; //Terminate the Main() returning void
            }

            //Prompt for an operation
            Console.WriteLine("Choose ADD, SUB, MULT OR DIV: ");
            operation = Console.ReadLine().ToLower();

            //Addition
            if (operation == add)
            {
                result = firstNumber + secondNumber;
                result = Math.Round(result, 2);
                Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

            }
            //Subtraction
            else if (operation == sub)
            {
                result = firstNumber - secondNumber;
                result = Math.Round(result, 2);
                Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
            }
            //Multiplication
            else if (operation == mult)
            {
                result = firstNumber * secondNumber;
                result = Math.Round(result, 2);
                Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

            }
            //Division
            else if (operation == div)
            {
                 if (secondNumber == 0)
                {
                    //Display error
                    //Display the error message
                    Console.WriteLine("Invalid second Number. ");
                    //Prompt for any key to exit 
                    Console.WriteLine("\nPress sny key to exit...");
                    Console.ReadKey();
                    return; //Terminate the Main() returning void

                }
                result = firstNumber / secondNumber;
                result = Math.Round(result, 2);
                Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

            }
            // WHEN ALL PREVIOUS STATEMENTS ARE FALSE
            else
            {
                Console.WriteLine("{0} Invalid Operation",operation);
            }
            // Press any key to exit
            Console.ReadKey();

        }
    }
}
