namespace Homework04._12
{
    internal class Exercise6_7
    {
        static List<string> names = new List<string>();
        public static void RunNamesMenu()
        {
            while (true)
            {
                int choice = Exercise6_7.Menu();

                if (choice == 1)
                    Exercise6_7.AddNames();
                else if (choice == 2)
                    Exercise6_7.RemoveNames();
                else break;
            }
        }

        public static int Menu()
        {
            Console.WriteLine("1.Add names");
            Console.WriteLine("2.Remove names");
            Console.WriteLine("3.Back to main menu");
            Console.WriteLine("Please select an operation and click Enter:");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.Write("Invalid input! Enter 1,2 or 3: ");
            }

            return choice;
        }

        public static void AddNames()
        {
            names.Clear();

            Console.WriteLine("Please enter five names:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter name #{i + 1}: ");
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine("List of names:");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }

        public static void RemoveNames()
        {
            if (names.Count == 0)
            {
                Console.WriteLine("The list is empty!Add names first.");
                return;
            }

            Console.WriteLine("Enter a name to remove:");
            string nameToRemove = Console.ReadLine();

            if (names.Remove(nameToRemove))
            {
                Console.WriteLine($"{nameToRemove} was removed successfully!");
            }
            else
            {
                Console.WriteLine("This name doesn't exist in the list!");
            }

            Console.WriteLine("Updated list:");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }

    }
}



