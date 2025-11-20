namespace Calculator
{
    internal interface ICalculatorOperations
    {
        internal double Addition(double a, double b);
        internal double Subtraction(double a, double b);
        internal double Multiplication(double a, double b);
        internal double Division(double a, double b);
        internal double Percent(double number, double percent);
        internal double SquareRoot(double a);
    }
}
