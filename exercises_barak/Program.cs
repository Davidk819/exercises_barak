using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine();
            while (true)
            {
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
            }
        }
    }
}
