﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace exercises_barak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine("Welcome to the calculator");
            while (true)
            {
                Console.WriteLine("Enter the Expression (for example: 3*4 ), (or type 'exit' to quit):");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;
                try
                {
                var result = calculator.ExpressionExtract(input);
                Console.WriteLine("result: ");
                Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                /*
                Console.WriteLine("Enter the first number (or type 'exit' to quit):");
                string input1 = Console.ReadLine();
                if (input1.ToLower() == "exit") break;
                if (!double.TryParse(input1, out double number1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Enter the second number:");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "exit") break;
                if (!double.TryParse(input2, out double number2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.WriteLine("Enter the operation (+, -, *, /):");
                string operation = Console.ReadLine();
                if (operation.ToLower() == "exit") break;
                if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                {
                    Console.WriteLine("Invalid operation. Please enter a valid operation.");
                    continue;
                }

                var result = calculator.Calculate(Convert.ToDouble(input1), Convert.ToDouble(input2), operation);
                Console.WriteLine("result: ");
                Console.WriteLine(result);
                */
            }
        }
    }
}
