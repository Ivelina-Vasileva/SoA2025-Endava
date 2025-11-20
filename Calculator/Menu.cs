namespace Calculator
{
    internal static class Menu
    {
        public static int ShowMainMenu()
        {
            Console.WriteLine("1.Addition(+)");
            Console.WriteLine("2.Subtraction(-)");
            Console.WriteLine("3.Multiplication(*)");
            Console.WriteLine("4.Division(/)");
            Console.WriteLine("5.Percent(%)");
            Console.WriteLine("6.Square Root(√)");
            Console.WriteLine("7.Exit");
            Console.WriteLine("Please select an operation and click Enter:");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
            {
                Console.Write("Invalid input! Enter a number between 1 and 7: ");
            }

            return choice;
        }
    }
}
