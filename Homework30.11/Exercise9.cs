namespace Homework30._11
{
    internal class Exercise9
    {
        public static void Run()
        {
            string sentence = "I’m doing my best to learn C#";
            Dictionary<string, int> result = CountLetterOccurrences(sentence);

            foreach (var pair in result)
            {
                Console.WriteLine($"‘{pair.Key}’ has occurred {pair.Value} {(pair.Value == 1 ? "time" : "times")}");
            }
        }

        public static Dictionary<string, int> CountLetterOccurrences(string sentence)
        {
            Dictionary<string, int> letterCounts = new Dictionary<string, int>();

            if (string.IsNullOrEmpty(sentence))
            {
                return letterCounts;
            }

            foreach (char character in sentence)
            {
                if (char.IsLetter(character))
                {
                    string letter = char.ToLower(character).ToString();

                    if (letterCounts.ContainsKey(letter))
                    {
                        letterCounts[letter]++;
                    }
                    else
                    {
                        letterCounts[letter] = 1;
                    }
                }
            }

            return letterCounts;
        }

    }
}


