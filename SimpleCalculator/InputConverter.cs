using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double GetValidNumber(string prompt)
        {
            double number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                isValid = double.TryParse(input, out number);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            return number;
        }

        public static string GetValidOperation()
        {
            string operation = string.Empty;
            string[] validOperations = { "+", "-", "*", "/", "%" };

            Console.WriteLine("Enter an option from the following:");
            foreach (var op in validOperations)
            {
                Console.WriteLine($"\t{op}");
            }

            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Enter an option: ");
                operation = Console.ReadLine();
                if (Array.Exists(validOperations, op => op == operation))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please enter one of the following: + : add, - : substract, * : multiply, / : divide, % : modulus.");
                }
            }

            return operation;
        }
    }
}
