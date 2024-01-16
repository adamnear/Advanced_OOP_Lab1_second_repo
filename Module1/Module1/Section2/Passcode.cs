namespace Section2
{
    internal class Passcode
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the pass code");
            var code = Console.ReadLine();

            if (code == "secret")
            {
                Console.WriteLine("Authenticated");
            }
            else if (code != "secret")
            {
                Console.WriteLine("Not Authenticated");
            }
        }
    }
}
