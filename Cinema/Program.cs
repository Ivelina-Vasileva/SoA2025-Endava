namespace Cinema
{
    internal class Cinema
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cinema Ticket Booking System!");

            Console.WriteLine("Please select the type of screen:");
            string typeOfScreen = Console.ReadLine();

            Console.WriteLine("Please enter the number of rows:");
            int numberOfRows = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of columns:");
            int numberOfColumns = int.Parse(Console.ReadLine());

            double pricePerTicket = 0;

            if (typeOfScreen == "Premiere")
            {
                pricePerTicket = 12.00;
            }
            if (typeOfScreen == "Normal")
            {
                pricePerTicket = 7.50;
            }
            if (typeOfScreen == "Discount")
            {
                pricePerTicket = 5.00;
            }

            double totalRevenue = numberOfRows * numberOfColumns * pricePerTicket;

            Console.WriteLine($"Total revenue: {totalRevenue:F2} EUR");
        }

    }
}

