namespace SpyCodeGenerator;
internal class Program
{
    private static void Main(string[] args)
    {
        string firstName = "Ivelina";
        string lastName = "Vasileva";
        string CodeName = CreateCodeName(firstName, lastName);
        string shifted = ShiftLetters(CodeName);
        Console.WriteLine($"Code name for {firstName} {lastName} is: {CodeName}");
        Console.WriteLine($"Shifted Letters: {shifted}");
    }

    public static string CreateCodeName(string firstName, string lastName)
    {
        string firstPart;

        if (firstName.Length < 2)
        {
            firstPart = firstName;
        }
        else
        {
            string firstTwoLetter = firstName.Substring(0, 2);

            firstPart = $"{firstTwoLetter[1]}{firstTwoLetter[0]}";
        }

        string secondPart;

        if (lastName.Length < 3)
        {
            secondPart = lastName;
        }
        else
        {
            string lastThreeLetter = lastName.Substring(lastName.Length - 3);

            char[] chars = lastThreeLetter.ToCharArray();
            char temp = chars[0];
            chars[0] = chars[2];
            chars[2] = temp;

            secondPart = new string(chars);
        }
        string uppercase = (firstPart + secondPart).ToUpper();

        return uppercase;

    }

    public static string ShiftLetters(string text)
    {
        char[] shiftedChars = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];

            if (char.IsLetter(currentChar))
            {

                char shiftedChar = (char)(((currentChar - 'A' + 3) % 26) + 'A');
                shiftedChars[i] = shiftedChar;
            }
            else
            {
                shiftedChars[i] = currentChar;
            }
        }

        return new string(shiftedChars);

    }
}


