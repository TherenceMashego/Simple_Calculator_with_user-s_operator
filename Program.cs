using System;

namespace Simple_Calculator_with_user_s_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            // Input validation for the first number
            Console.WriteLine("Enter the first number:");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            Console.WriteLine("Enter an operator (+, -, *, /):");
            string op = Console.ReadLine();

            // Input validation for the second number
            Console.WriteLine("Enter the second number:");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            CalculateAndDisplayResult(num1, op, num2);
        }

        static void CalculateAndDisplayResult(double num1, string op, double num2)
        {
            double result = 0.0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Not a valid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
