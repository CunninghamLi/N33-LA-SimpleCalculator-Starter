using System;

namespace CalculatorEngineLibrary
{
    public class CalculatorEngine
    {
        public double Calculate(string operation, double num1, double num2)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    return num1 / num2;
                case "%":
                    if (num2 == 0)
                        throw new DivideByZeroException("Cannot perform modulus by zero.");
                    return num1 % num2;
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
        }
    }
}
