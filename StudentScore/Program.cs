using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentScores = new Dictionary<string, int>();

            AddStudents(studentScores);
            PrintStudents(studentScores);
            double average = CalculateAverage(studentScores);

            Console.WriteLine($"Average score: {average:F2}");
        }
        static void AddStudents(Dictionary<string, int> scores)
        {
            while (true)
            {
                Console.Write("Enter student name or type 'finish' to finish added names:");

                string name = Console.ReadLine();

                if (name.ToLower() == "finish") 
                    break;

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name can't be empty.Try again.");
                    continue;
                }

                Console.Write($"Enter score for {name}: ");

                if (!int.TryParse(Console.ReadLine(), out int score) || score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid score.Please enter a number between 0 and 100.");
                    continue;
                }

                scores[name] = score;
            }
        }
        static double CalculateAverage(Dictionary<string, int> scores)
        {
            if (scores.Count == 0) 
                return 0;
            return scores.Values.Average();
        }

        static void PrintStudents(Dictionary<string, int> scores)
        {
            Console.WriteLine("Student scores:");

            foreach (var pair in scores)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}



