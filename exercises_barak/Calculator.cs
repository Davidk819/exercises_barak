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
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            throw null;
        }
        public double Multiply(double num1, double num2)
        {
            throw null;
        }
        public double Divide(double num1, double num2)
        {
            throw null;
        }

    }
}
