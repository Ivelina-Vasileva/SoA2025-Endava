namespace LoginSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Login System");

            string correctUsername = "Iveto";
            string correctPassword = "Iveto123";

            Console.Write("Enter your username and click Enter: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password and click Enter: ");
            string password = Console.ReadLine();


            if (username == correctUsername) // Checking if username is correct
            {
                if (password == correctPassword) // Checking if password is correct
                {
                    Console.WriteLine("Login successful"); //Correct Username and Password
                }

                else
                {
                    Console.WriteLine("Login failed! Invalid password."); //Wrong Password
                }

            }
            else
            {
                Console.WriteLine("Username not found!"); //Wrong Username
            }
        }
    }
}

