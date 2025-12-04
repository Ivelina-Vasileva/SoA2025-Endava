using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework30._11
{
    internal class Exercise6
    {
        public static void ExtractDomain()
        {
            string email = "randomName@example.com";
            string domain = email.Split('@')[1];

            Console.WriteLine(domain);
           
        }
    }
}
