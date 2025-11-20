namespace Calculator
{
    internal class InputHelper
    {
        public static double ReadNumber(string message)
        {
            double value;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input! Enter a number: ");
            }
            return value;
        }
    }
}