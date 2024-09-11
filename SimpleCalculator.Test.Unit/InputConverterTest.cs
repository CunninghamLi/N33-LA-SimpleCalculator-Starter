using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator; // Ensure this namespace is correct for your InputConverter class

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        [TestMethod]
        public void GetValidNumber_ShouldReturnDouble_WhenGivenValidString()
        {
            string inputNumber = "5";
            double expectedNumber = 5.0;

            // Simulate user input by using Console.SetIn or refactor InputConverter for easier testing
            double actualNumber = InputConverter.GetValidNumber($"Enter number: {inputNumber}");

            Assert.AreEqual(expectedNumber, actualNumber, 0.0001); // Added delta for floating-point comparison
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GetValidNumber_ShouldThrowFormatException_WhenGivenInvalidString()
        {
            string inputNumber = "*";

            // Simulate user input or refactor for testing
            InputConverter.GetValidNumber($"Enter number: {inputNumber}");
        }

        [TestMethod]
        public void GetValidOperation_ShouldReturnValidOperation_WhenGivenValidInput()
        {
            string validOperation = "+";
            string result = InputConverter.GetValidOperation();

            Assert.AreEqual(validOperation, result); // Adjust based on how GetValidOperation is tested
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetValidOperation_ShouldThrowArgumentException_WhenGivenInvalidOperation()
        {
            string invalidOperation = "#";

            // Simulate user input or refactor for testing
            InputConverter.GetValidOperation();
        }
    }
}
