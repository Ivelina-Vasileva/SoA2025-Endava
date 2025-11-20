namespace Calculator
{
    internal class CalculatorOperations : ICalculatorOperations
    {
        public double Addition(double a, double b) => a + b;

        public double Subtraction(double a, double b) => a - b;

        public double Multiplication(double a, double b) => a * b;
        public double Division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Can't divide by zero!");
                return 0;
            }
            return a / b;
        }

        public double Percent(double number, double percent) => number * percent / 100;
        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Invalid input! Can't calculate square root of a negative number.");
                return 0;
            }
            return Math.Sqrt(a);
        }

    }
}

