namespace Section4
{
    // Enum for months
    public enum MonthCategory
    {
        Jan = 0,
        Feb = 1,
        Mar = 2,
        Apr = 3,
        May = 4,
        Jun = 5,
        Jul = 6,
        Aug = 7,
        Sep = 8,
        Oct = 9,
        Nov = 10,
        Dec = 11
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month (Jan = 0, Feb = 1, Mar = 2, etc.): ");
            MonthCategory monthName = (MonthCategory) month;

            // Convert month string to enum
            MonthCategory selectedMonth;
            if (!Enum.TryParse(inputMonth, true, out selectedMonth))
            {
                Console.WriteLine("Invalid month input.");
                return;
            }

            switch (month)
            {
                case 2:
                    Console.WriteLine("You are Aries");
                    break;
                case 2:
                    Console.WriteLine("You are Aries");
                    break;

                default:
                    Console.WriteLine("Invalid month input.");
                    break;
            }
        }
    }
}
