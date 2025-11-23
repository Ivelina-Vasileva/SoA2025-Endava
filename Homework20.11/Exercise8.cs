namespace DebbugingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 85; // Fixed: Changed from string to int
            if (score > 90) // Fixed: Added opening brace
            {
                Console.WriteLine("Great job!"); // Fixed: Added closing brace. It can also work without Opening and Closing brace if there's only one statement.
                                                 // There may be errors if we add more if statements later.
            }
        }
    }
}
// This is the provided buggy code with three errors.

/*namespace DebbugingPractice
{
class Program

{
static void Main(string[] args)
    {
        int score = "85"; 
        if (score > 90)
            Console.WriteLine("Great job!");

    }
}
}*/
