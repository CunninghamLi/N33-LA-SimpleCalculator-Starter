using System;
using CalculatorEngineLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = InputConverter.GetValidNumber("Enter number 1: ");
            double num2 = InputConverter.GetValidNumber("Enter number 2: ");
            string operation = InputConverter.GetValidOperation();

            var calculatorEngine = new CalculatorEngine();
            double result;

            try
            {
                result = calculatorEngine.Calculate(operation, num1, num2);
                Console.WriteLine($"Your result: {num1} {operation} {num2} = {result:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
