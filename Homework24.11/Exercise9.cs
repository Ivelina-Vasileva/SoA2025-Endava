using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework24._11
{
    internal class Exercise9
    {
        public static void DoWhileLoop()
        {
            string input;
            do
            {
                Console.WriteLine("Do you want to continue? (Y/N)");
                input = Console.ReadLine().ToUpper();
            } while (input != "N");
        }
    }
}
