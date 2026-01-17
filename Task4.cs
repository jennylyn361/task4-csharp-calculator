using System;

class ArithmeticCalculator
{
    // Separate method for Addition
    static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    // Separate method for Subtraction
    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    // Separate method for Multiplication
    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    // Separate method for Division (with zero check)
    static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
            return double.NaN;
        }
        return num1 / num2;
    }

    static void Main(string[] args)
    {
        bool keepRunning = true;

        // While loop to repeat until user says 'N'
        while (keepRunning)
        {
            // Show menu
            Console.WriteLine("\n--- Arithmetic Calculator ---");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.Write("Choose an operation (1-4): ");
            
            // Get user's choice
            int choice = int.Parse(Console.ReadLine());

            // Get two numbers from user
            Console.Write("Enter Value 1: ");
            double val1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Value 2: ");
            double val2 = double.Parse(Console.ReadLine());

            // Switch-case to pick operation
            double result = 0;
            string opSymbol = "";
            switch (choice)
            {
                case 1:
                    result = Add(val1, val2);
                    opSymbol = "+";
                    break;
                case 2:
                    result = Subtract(val1, val2);
                    opSymbol = "-";
                    break;
                case 3:
                    result = Multiply(val1, val2);
                    opSymbol = "*";
                    break;
                case 4:
                    result = Divide(val1, val2);
                    opSymbol = "/";
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please pick 1-4.");
                    continue;
            }

            // Show result if no error
            if (!double.IsNaN(result))
            {
                Console.WriteLine($"{val1} {opSymbol} {val2} = {result}");
            }

            // Ask to continue
            Console.Write("Continue? (Y/N): ");
            string response = Console.ReadLine().ToUpper();
            if (response != "Y")
            {
                keepRunning = false;
                Console.WriteLine("Thanks for using the calculator!");
            }
        }
    }
}
