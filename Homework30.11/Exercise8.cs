using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework30._11
{
    internal class Exercise8
    {
        public static void Run()
        {
            string a = "abba";
            string b = "abva";
            string c = "debel lebed";

            IsStringPalindrome(a);
            IsStringPalindrome(b);
            IsStringPalindrome(c);

            static void IsStringPalindrome(string str)
            {
                string reversed = new string(str.Reverse().ToArray());

                if (str.Equals(reversed, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"'{str}' is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"'{str}' is not a palindrome.");
                }

            }
          
        }
    }
}
