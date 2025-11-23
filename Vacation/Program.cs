namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your budget:");
            double budget = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the season (summer/winter):");
            string season = Console.ReadLine().ToLower(); // Convert input to lowercase to handle case sensitivity

            if (season != "summer" && season != "winter")
            {
                Console.WriteLine("Wrong season!Please enter 'summer' or 'winter'.");
                return;
            }
            string destination = "";
            string vacationType = "";
            double amountSpent = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    vacationType = "Camp";
                    amountSpent = budget * 0.30;
                }
                else if (season == "winter")
                {
                    vacationType = "Hotel";
                    amountSpent = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    vacationType = "Camp";
                    amountSpent = budget * 0.40;
                }
                else if (season == "winter")
                {
                    vacationType = "Hotel";
                    amountSpent = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                vacationType = "Hotel";
                amountSpent = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {amountSpent:F2}");// Тhe amount is rounded to the second decimal place 

        }
    }
}


