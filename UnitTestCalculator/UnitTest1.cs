using exercises_barak;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_TwoNumbersAndAdditionOperation_When_Calculating_Then_ReturnsSum()
        {
            var calculator = new Calculator();
            double num1 = 2;
            double num2 = 3;

            var result = calculator.Add(num1, num2);

            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void Given_TwoNumbersAndSubtractionOperation_When_Calculating_Then_ReturnsDifference()
        {
            var calculator = new Calculator();
            double num1 = 8;
            double num2 = 3;

            var result = calculator.Sub(num1, num2);

            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void Given_TwoNumbersAndMultiplicationOperation_When_Calculating_Then_ReturnsProduct()
        {
            var calculator = new Calculator();
            double num1 = 2;
            double num2 = 3;

            var result = calculator.Multiply(num1, num2);

            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void Given_TwoNumbersAndDivisionOperation_When_Calculating_Then_ReturnsQuotient()
        {
            var calculator = new Calculator();
            double num1 = 10;
            double num2 = 2;

            var result = calculator.Divide(num1, num2);

            Assert.AreEqual(5, result);
        }
    }
}
