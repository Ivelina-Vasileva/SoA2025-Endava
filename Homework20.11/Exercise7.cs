namespace Homework20._11
{
    public class Exercise7
    {
        public void Grades()
        {
            int grade = 0;

            while (true)
            {
                Console.Write("Enter the student's grade (Very bad(2) - Excelent(6)) and click Enter:");

                bool isNumber = int.TryParse(Console.ReadLine(), out grade);

                if (!isNumber) // Check if the input is a number
                {
                    Console.WriteLine("Invalid input. Please enter a number between 2 and 6.");

                    continue; // Prompt the user to enter the grade again
                }
                if (grade < 2 || grade > 6) //Check if the grade is within the valid range
                {
                    Console.WriteLine("Grade must be between 2 and 6. Please try again.");

                    continue; // Prompt the user to enter the grade again
                }
                if (grade >= 2)
                {

                    if (grade == 2)
                    {
                        Console.WriteLine(" The student's grade is Very bad"); // Output for grade 2
                    }

                    if (grade >= 3)
                    {
                        if (grade == 3)
                        {
                            Console.WriteLine(" The student's grade is Bad"); // Output for grade 3
                        }

                        if (grade >= 4)
                        {
                            if (grade == 4)
                            {
                                Console.WriteLine(" The student's grade is Good"); // Output for grade 4
                            }

                            if (grade >= 5)
                            {
                                if (grade == 5)
                                {
                                    Console.WriteLine(" The student's grade is Very Good"); // Output for grade 5
                                }

                                if (grade >= 6)
                                {
                                    if (grade == 6)
                                    {
                                        Console.WriteLine(" The student's grade is Excellent"); // Output for grade 6
                                    }



                                }

                            }
                        }
                    }
                }
                break; // Exit the loop after a valid grade is processed

            }
        }
    }
}
