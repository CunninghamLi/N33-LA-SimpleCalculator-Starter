using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorEngineLibrary; // Ensure this namespace is correct for your CalculatorEngine class

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            double number1 = 1.0;
            double number2 = 2.0;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3.0, result, 0.0001); // Added delta for floating-point comparison
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            double number1 = 1.0;
            double number2 = 2.0;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3.0, result, 0.0001); // Added delta for floating-point comparison
        }
    }
}
