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
    }
}
