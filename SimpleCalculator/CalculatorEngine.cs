using System;


namespace CalculatorEngineLibrary
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;


            switch (argOperation.ToLower())
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "-":
                case "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "*":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "/":
                case "divide":
                    if (argSecondNumber != 0)
                    {
                        result = argFirstNumber / argSecondNumber;
                    }
                    else
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    break;
                case "%":
                case "modulus":
                    if (argSecondNumber != 0)
                    {
                        result = argFirstNumber % argSecondNumber;
                    }
                    else
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    break;
                default:
                    throw new InvalidOperationException("Operation is not supported.");
            }


            return result;
        }
    }
}