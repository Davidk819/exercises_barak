using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_barak
{
    public class Calculator
    {
        public double Calculate(double num1, double num2, string operation)
        {
            if (num1 < int.MinValue || num1 > int.MaxValue || num2 < int.MinValue || num2 > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException("One or two of the numbers are out of the range");
            }

            switch (operation)
            {
                case "+":
                    return Add(num1,num2);
                case "-": 
                    return Sub(num1,num2);
                case "*":
                    return Multiply(num1, num2);
                case "/":
                    return Divide(num1, num2);
                default:
                    throw new InvalidOperationException("Invalid operation");
            }
        }
        public double ExpressionExtract(string expression)
        {
            expression = expression.Replace(" ", "");
            string[] parts = expression.Split(new char[] { '*', '/', '+', '-' });
            if (parts.Length != 2)
            {
                throw new ArgumentException("The expression must contain exactly two numbers and valid operator");
            }
            double num1 = double.Parse(parts[0]);
            double num2 = double.Parse(parts[1]);
            char operatorChar =  expression[parts[0].Length];
            return Calculate(num1, num2, operatorChar.ToString());

        }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }

    }
}
