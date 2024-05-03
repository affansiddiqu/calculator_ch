// See https://aka.ms/new-console-template for more information
using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitRequested = false;

            do
            {
                Console.WriteLine("Choose calculator type:");
                Console.WriteLine("1. Normal Calculator");
                Console.WriteLine("2. Scientific Calculator");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunNormalCalculator();
                        break;
                    case "2":
                        RunScientificCalculator();
                        break;
                    case "3":
                        exitRequested = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (!exitRequested);
        }

        static void RunNormalCalculator()
        {
            Console.WriteLine("Normal Calculator Operations:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            double num1, num2;
            double result = 0;

            switch (choice)
            {
                case "1":
                    num1 = GetNumber("Enter the first number: ");
                    num2 = GetNumber("Enter the second number: ");
                    result = num1 + num2;
                    break;
                case "2":
                    num1 = GetNumber("Enter the first number: ");
                    num2 = GetNumber("Enter the second number: ");
                    result = num1 - num2;
                    break;
                case "3":
                    num1 = GetNumber("Enter the first number: ");
                    num2 = GetNumber("Enter the second number: ");
                    result = num1 * num2;
                    break;
                case "4":
                    num1 = GetNumber("Enter the first number: ");
                    num2 = GetNumber("Enter the second number (not zero): ");
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Division by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }

        static void RunScientificCalculator()
        {
            Console.WriteLine("Scientific Calculator Operations:");
            Console.WriteLine("1. Exponentiation (a^b)");
            Console.WriteLine("2. Square root");
            Console.WriteLine("3. Logarithm (base 10)");
            Console.WriteLine("4. Sine");
            Console.WriteLine("5. Cosine");
            Console.WriteLine("6. Tangent");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            double result = 0;

            switch (choice)
            {
                case "1":
                    double baseNum = GetNumber("Enter base: ");
                    double exponent = GetNumber("Enter exponent: ");
                    result = Math.Pow(baseNum, exponent);
                    break;
                case "2":
                    double number = GetNumber("Enter number: ");
                    if (number >= 0)
                        result = Math.Sqrt(number);
                    else
                        Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                    break;
                case "3":
                    double logNumber = GetNumber("Enter number: ");
                    if (logNumber > 0)
                        result = Math.Log10(logNumber);
                    else
                        Console.WriteLine("Error: Logarithm of non-positive number is undefined.");
                    break;
                case "4":
                    double angleSin = GetNumber("Enter angle in degrees: ");
                    result = Math.Sin(angleSin * Math.PI / 180);
                    break;
                case "5":
                    double angleCos = GetNumber("Enter angle in degrees: ");
                    result = Math.Cos(angleCos * Math.PI / 180);
                    break;
                case "6":
                    double angleTan = GetNumber("Enter angle in degrees: ");
                    result = Math.Tan(angleTan * Math.PI / 180);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }

        static double GetNumber(string message)
        {
            double number;
            do
            {
                Console.Write(message);
            } while (!double.TryParse(Console.ReadLine(), out number));
            return number;
        }
    }
}

