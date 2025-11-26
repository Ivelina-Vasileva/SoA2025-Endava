using System;
using Homework24._11;

namespace Homework24._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print numbers from 1 to 10 using a for loop
            Exercise6.Print();
            ////Print names from an array using a foreach loop
            Exercise7.ForeachLoop();
            ////Ask the user for a number greater than 100 using a while loop, exit the loop when you print all numbers between 1 and the provided number.
            Exercise8.WhileLoop();
            //Repeat a prompt until the user enters „N“ using a do-while loop
            Exercise9.DoWhileLoop();
            //Print a multiplication table from 1 to 5 using nested for loops.
            Exercise10.MultiplicationTable();
            //Print all primary numbers between 1 and n where n is provided via the console.
            Exercise11.PrintPrimeNumbers();
        }
    }
}
