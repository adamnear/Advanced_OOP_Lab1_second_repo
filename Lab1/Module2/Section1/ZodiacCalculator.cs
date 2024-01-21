namespace Section1
{
    class Data
    {
        public string Name;
        public int Age;
        public string Month;
        public int Day;

        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);
            Console.WriteLine("Your day of birth is: {0}", Day);
        }

        public void DetermineZodiacSign()
        {
            switch (Month.ToLower())
            {
                case "march":
                    Console.WriteLine("You are an Aries");
                    break;
                case "april":
                    Console.WriteLine("You are a Taurus");
                    break;
                case "may":
                    Console.WriteLine("You are a Gemini");
                    break;
                case "june":
                    Console.WriteLine("You are a Cancer");
                    break;
                case "july":
                    Console.WriteLine("You are a Leo");
                    break;
                case "august":
                    Console.WriteLine("You are a Virgo");
                    break;
                case "september":
                    Console.WriteLine("You are a Libra");
                    break;
                case "october":
                    Console.WriteLine("You are a Scorpio");
                    break;
                case "november":
                    Console.WriteLine("You are a Sagittarius");
                    break;
                case "december":
                    Console.WriteLine("You are a Capricorn");
                    break;
                case "january":
                    Console.WriteLine("You are an Aquarius");
                    break;
                case "february":
                    Console.WriteLine("You are a Pisces");
                    break;
                default:
                    Console.WriteLine("Invalid month entered");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = (TryAnswer());

            Console.WriteLine("What is your age?");
            data.Age = (TryParseInt());

            Console.WriteLine("What is your birth month?");
            data.Month = (TryAnswer());

            Console.WriteLine("What is your day of birth?");
            data.Day = (TryParseInt());

            data.Display();
            data.DetermineZodiacSign();
        }

        static string TryAnswer()
        {
            string answer;
            do
            {
                answer = Console.ReadLine().Trim();
            } while (string.IsNullOrEmpty(answer));

            return answer;
        }

        static int TryParseInt()
        {
            int result;
            string input;
            do
            {
                input = Console.ReadLine().Trim();
            } while (!int.TryParse(input, out result));

            return result;
        }
    }
}