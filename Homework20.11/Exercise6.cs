namespace Homework20._11
{
    public class Exercise6
    {
        public void Run()
        {
            Console.Write("Please, enter your age and click Enter:");
            var reasonableAge = 150;
            int age = int.Parse(Console.ReadLine());

            if (age < 0 || age > reasonableAge)
            {
                Console.WriteLine("Invalid age entered.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }

        }
    }
}
