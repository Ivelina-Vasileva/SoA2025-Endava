namespace Homework04._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select exercise:");
                Console.WriteLine("1.Add/Remove 5 names");
                Console.WriteLine("2.Countries and capitals");
                Console.WriteLine("3.Exit");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.Write("Invalid input! Enter 1,2 or 3: ");
                }

                if (choice == 1)
                {
                    Exercise6_7.RunNamesMenu();
                }
                else if (choice == 2)
                {
                    Exercise8_10.RunCountries();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
