namespace Homework24._11
{
    internal class Exercise11
    {
        public static void PrintPrimeNumbers()
        {
            Console.WriteLine("Enter a number:");

            int n = int.Parse(Console.ReadLine());
            int number = 2;

            while (number <= n)
            {
                bool isPrime = true;
                int divisor = 2;


                while (divisor <= Math.Sqrt(number))
                {
                    if (number % divisor == 0) // if number is divisible by divisor without remainder it is not prime number
                    {
                        isPrime = false;
                        break;
                    }
                    divisor++;
                }

                if (isPrime) // if the number is prime, print it
                {
                    Console.WriteLine(number);
                }

                number++;

            }

            Console.WriteLine("The printed numbers are Prime numbers." + Environment.NewLine + " A prime number is a natural number greater than 1 that has only two factors: 1 and itself. " + Environment.NewLine + " For example, 3 is a prime number because it can only be divided by 1 and 3. ");
        }
    }
}

