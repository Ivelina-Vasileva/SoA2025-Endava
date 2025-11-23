namespace SummerClothing
{
    internal class SummerClothing
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter degrees:");
            int degrees = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Time of the day (Morning, Afternoon, Evening):");
            string timeOfTheDay = (Console.ReadLine());

            string clothes = "";
            string shoes = "";

            if (degrees != 0 && timeOfTheDay != "")
            {

                if (degrees <= 10 || degrees <= 18)
                {
                    if (timeOfTheDay == "Morning")
                    {
                        clothes = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    if (timeOfTheDay == "Afternoon" || timeOfTheDay == "Evening")
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                }

                if (degrees < 18 || degrees <= 24)
                {
                    if (timeOfTheDay == "Morning" || timeOfTheDay == "Evening")
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }

                    if (timeOfTheDay == "Afternoon")
                    {
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                    }

                }

                if (degrees >= 25)
                {
                    if (timeOfTheDay == "Morning")
                    {
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                    }
                    if (timeOfTheDay == "Afternoon")
                    {
                        clothes = "Swim Suit";
                        shoes = "Barefoot";
                    }

                    if (timeOfTheDay == "Evening")
                    {
                        clothes = "Shirt";
                        shoes = "Moccasins";
                    }
                }
                Console.WriteLine($"It's {degrees} degrees, get your {clothes} and {shoes}.");

            }
        }
    }
}
