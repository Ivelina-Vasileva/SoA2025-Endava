namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a custom namespace called HomeworkUtilities with a class Printer that prints a message 
            Printer printer = new Printer();
            printer.PrintMessage();
            //Declare variables of different types and use kevwords like const, var, and static. 
            Exercise7 exercise7 = new Exercise7();
            exercise7.Variables();
            //Perform arithmetic and logical operations on two integers and print the results.
            Exercise8 exercise8 = new Exercise8();
            exercise8.Operations();
        }
    }
}