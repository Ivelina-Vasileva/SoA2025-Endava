using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework30._11
{
    internal class Exercise10
    {
        public static void Run()
        {
            string[] examples = { "Python", "PHP", "C#" };

            foreach (var str in examples)
            {
                Console.WriteLine($"Original string: {str}");
                Console.WriteLine($"Middle character(s) of the said string:{GetMiddleCharacters(str)}");

            }
        }

        static string GetMiddleCharacters(string str)
        {
            int length = str.Length;
            int middle = length / 2;

            if (length % 2 == 0) 
            {
                return str.Substring(middle - 1, 2);
            }
            else 
            {
                return str.Substring(middle, 1);
            }
        }
    }
}
    
       