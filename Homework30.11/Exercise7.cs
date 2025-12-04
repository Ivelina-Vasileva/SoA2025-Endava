using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework30._11
{
    internal class Exercise7
    {
        public static void CompareString()
        {
            string a = "Test";
            string b = "test";
             
            bool areEqual = a.Equals(b, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(areEqual);
        }
    }
}
