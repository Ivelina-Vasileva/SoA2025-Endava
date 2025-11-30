namespace Homework27._11
{
    internal class Exercise7
    {
        public static void Run()
        {
            string userName = "";

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Please enter your name, brave coder: ");
                userName = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(userName))
                {
                    Console.WriteLine("Name is required!");
                }
            }

            string greeting = MagicGreeting(userName);
            Console.WriteLine(greeting);
        }

        private static string MagicGreeting(string name)
        {
            Random random = new Random();

            string[] greetings = {
                "Hello, adventurer {0}!",
                "Welcome to the realm {0}!",
                "Greetings, traveler {0}!",
                "Salutations, hero {0}!",
                "Welcome, mighty {0}",
                "Behold, the legendary {0} has arrived!"
            };

            int randomNum = random.Next(0, greetings.Length);

            string greeting = $"{greetings[randomNum].Replace("{0}", name)}";

            return greeting;
        }
    }

}