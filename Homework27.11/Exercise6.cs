namespace Homework27._11
{
    internal class Exercise6
    {
        public static void Run()
        {
            Console.WriteLine("Please enter integers separated by spaces:");

            string input = Console.ReadLine();

            int[] numbers = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> inputList = numbers.ToList();
            List<int> sorted = new List<int>(inputList.Count);

            while (inputList.Count > 0)
            {
                int biggest = biggestArrayInteger(inputList);
                sorted.Add(biggest);
                inputList.Remove(biggest);
            }

            Console.WriteLine("Sorted in descending order:");
            Console.WriteLine(string.Join(" ", sorted));
        }

        private static int biggestArrayInteger(List<int> numbers)
        {
            int biggest = int.MinValue;

            foreach (int number in numbers)
            {
                if (number > biggest)
                {
                    biggest = number;
                }
            }

            return biggest;
        }
    }
}
