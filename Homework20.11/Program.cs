namespace Homework20._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their age and print whether they are a minor or an adult 
            Exercise6 ex6 = new Exercise6();
            ex6.Run();
            //Ask for a student‘s grade and print a performance message using nested if statements.
            Exercise7 ex7 = new Exercise7();
            ex7.Grades();
            //Fix the provided buggy code with three errors.
            BuggyCodeFixed.FixTheBugs();
        }
    }
}
