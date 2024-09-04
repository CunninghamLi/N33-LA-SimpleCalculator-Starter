using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double result;
            if (double.TryParse(argTextInput, out result))
            {
                return result;
            }
            else
            {
                throw new FormatException("Invalid input. Please enter a valid numeric value.");
            }
        }
    }
}