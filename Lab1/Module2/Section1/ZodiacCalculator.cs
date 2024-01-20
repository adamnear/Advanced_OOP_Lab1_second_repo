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

            if (Month == "march")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (Month == "april")
            {
                Console.WriteLine("You are an Taurus");
            }
            else if (Month == "may")
            {
                Console.WriteLine("You are an Gemini");
            }
            else if (Month == "june")
            {
                Console.WriteLine("You are an Cancer");
            }
            else if (Month == "july")
            {
                Console.WriteLine("You are an Leo");
            }
            else if (Month == "august")
            {
                Console.WriteLine("You are an Virgo");
            }
            else if (Month == "september")
            {
                Console.WriteLine("You are an Libra");
            }
            else if (Month == "october")
            {
                Console.WriteLine("You are an Capricorn");
            }
            else if (Month == "november")
            {
                Console.WriteLine("You are an Aquarius");
            }
            else if (Month == "december")
            {
                Console.WriteLine("You are an Pisces");
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
            data.Age = (TryAnswer());

            Console.WriteLine("What is your birth month?");
            data.Month = (TryAnswer());

            Console.WriteLine("What is your day of birth?");
            data.Day = (TryAnswer());

            data.Display();

            if (Month == "march")
            {
                Console.WriteLine("You are an Aries");
            }
            else if (Month == "april")
            {
                Console.WriteLine("You are an Taurus");
            }
            else if (Month == "may")
            {
                Console.WriteLine("You are an Gemini");
            }
            else if (Month == "june")
            {
                Console.WriteLine("You are an Cancer");
            }
            else if (Month == "july")
            {
                Console.WriteLine("You are an Leo");
            }
            else if (Month == "august")
            {
                Console.WriteLine("You are an Virgo");
            }
            else if (Month == "september")
            {
                Console.WriteLine("You are an Libra");
            }
            else if (Month == "october")
            {
                Console.WriteLine("You are an Capricorn");
            }
            else if (Month == "november")
            {
                Console.WriteLine("You are an Aquarius");
            }
            else if (Month == "december")
            {
                Console.WriteLine("You are an Pisces");
            }
        }
    }
}