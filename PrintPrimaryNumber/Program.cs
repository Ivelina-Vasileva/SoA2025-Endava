namespace Homework24._11
{
    internal class Exercise11
    {
        public static void Main()
        {


            while (true)
            {
                Console.WriteLine("Enter number between -1000 and 999:");
                int N = int.Parse(Console.ReadLine());

                if (N < -1000 || N > 999)
                {

                    Console.WriteLine("Please enter a number between -1000 and 999!");

                    continue;
                }

                int i = N;

                while (i <= 999 && i >= -1000)
                {
                    if (i >= 0 && i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }

                    i++;
                }

                break;
            }
        }
    }
}

