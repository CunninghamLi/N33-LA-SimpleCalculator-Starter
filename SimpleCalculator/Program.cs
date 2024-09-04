using System;
using System.Collections.Generic;
using System.Text;
using CalculatorEngineLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double firstNumber = GetValidNumber("Enter the first number:");
                double secondNumber = GetValidNumber("Enter the second number:");
                string operation = GetValidOperation("Enter the operation (+, -, *, /, %):");

                var calculatorEngine = new CalculatorEngine();
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                string formattedResult = FormatResult(firstNumber, secondNumber, operation, result);
                Console.WriteLine(formattedResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static double GetValidNumber(string prompt)
        {
            double number;
            Console.WriteLine(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }
            return number;
        }

        static string GetValidOperation(string prompt)
        {
            string[] validOperations = { "+", "-", "*", "/", "%", "add", "subtract", "multiply", "divide", "modulus" };
            string operation;
            Console.WriteLine(prompt);
            operation = Console.ReadLine().ToLower();
            while (Array.IndexOf(validOperations, operation) == -1)
            {
                Console.WriteLine("Invalid operation. Valid operations are +, -, *, /, %, add, subtract, multiply, divide, modulus:");
                operation = Console.ReadLine().ToLower();
            }
            return operation;
        }


        static string FormatResult(double firstNumber, double secondNumber, string operation, double result)
        {
            var operationWords = new Dictionary<string, string>
    {
        { "+", "plus" },
        { "-", "minus" },
        { "*", "multiplied by" },
        { "/", "divided by" },
        { "%", "modulus" },
        { "add", "plus" },
        { "subtract", "minus" },
        { "multiply", "multiplied by" },
        { "divide", "divided by" },
        { "modulus", "modulus" }
    };

            var operationWord = operationWords.ContainsKey(operation) ? operationWords[operation] : operation;

            var sb = new StringBuilder();
            sb.AppendFormat("The value {0} {1} the value {2} is equal to {3:F2}.", firstNumber, operationWord, secondNumber, result);
            return sb.ToString();
        }
    }
}

 