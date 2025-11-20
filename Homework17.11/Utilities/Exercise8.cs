namespace Homework1
{
    public class Exercise8
    {
        public void Operations()
        {
            int a = 10;
            int b = 5;
            // Basic arithmetic operations
            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {a / b}");
            Console.WriteLine($"Modulus: {a % b}");
            Console.WriteLine($"Increment a: {++a}");
            // Basic logical operations
            bool x = true;
            bool y = false;
            Console.WriteLine($"AND: {x && y}");
            Console.WriteLine($"OR: {x || y}");
            Console.WriteLine($"NOT x: {!x}");
            Console.WriteLine($"XOR: {x ^ y}");
        }
    }
}