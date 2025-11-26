namespace Homework24._11
{
    internal class Exercise8
    {
        public static void WhileLoop()
        {
            Console.WriteLine("Enter number greater than 100");

            int number = 0;
            int i = 1;

            while (true)
            {
                if (number <= 100)
                {
                    number = int.Parse(Console.ReadLine());

                    if (number <= 100)
                    {
                        Console.WriteLine("The number is less or equal to 100. Please enter number greater than 100.");
                        continue;  //Ask for input again
                    }

                    Console.WriteLine("Printing numbers from 1 to " + number + ":");
                }

                // Print numbers from 1 to number
                Console.WriteLine(i);
                i++;

                //When i becomes greater than number, break the loop
                if (i > number)
                {
                    break;
                }
            }
        }
    }
}

