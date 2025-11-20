using Calculator;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Console.WriteLine("Welcome to the Calculator App!");

            while (!exit)
            {
                int choice = Menu.ShowMainMenu();
                double a, b, result;

                CalculatorOperations calc = new CalculatorOperations();

                switch (choice)
                {
                    case 1:
                        // Addition
                        a = InputHelper.ReadNumber("Enter first number: ");
                        b = InputHelper.ReadNumber("Enter second number: ");
                        result = calc.Addition(a, b);
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 2:
                        // Subtraction
                        a = InputHelper.ReadNumber("Enter first number: ");
                        b = InputHelper.ReadNumber("Enter second number: ");
                        result = calc.Subtraction(a, b);
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 3:
                        // Multiplication
                        a = InputHelper.ReadNumber("Enter first number: ");
                        b = InputHelper.ReadNumber("Enter second number: ");
                        result = calc.Multiplication(a, b);
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 4:
                        // Division
                        a = InputHelper.ReadNumber("Enter first number: ");
                        b = InputHelper.ReadNumber("Enter second number: ");
                        result = calc.Division(a, b);
                        Console.WriteLine($"Result: {result}");

                        break;
                    case 5:
                        // Percent
                        a = InputHelper.ReadNumber("Enter number: ");
                        b = InputHelper.ReadNumber("Enter the percent (%): ");

                        result = calc.Percent(a, b);
                        Console.WriteLine($"Result: {result}");
                        break;
                    case 6:
                        // Square Root
                        a = InputHelper.ReadNumber("Enter number: ");
                        result = calc.SquareRoot(a);
                        Console.WriteLine($"Result: {result}");

                        break;
                    case 7:
                        exit = true;
                        Console.WriteLine("Exiting...Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1-7.");
                        break;
                }
            }
        }
    }
}
