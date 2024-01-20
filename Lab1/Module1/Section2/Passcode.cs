namespace Section2
{
    internal class Passcode
    {
        static void Main(string[] args)
        {
            bool isAuthenticated = false;

            Console.WriteLine("What is the current pass code");
            var currentCode = Console.ReadLine();

            if (currentCode == "secret")
            {
                Console.WriteLine("Authenticated");
                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                Console.WriteLine("Do you want to change the pass code? (yes/no)");
                var changeOption = Console.ReadLine();

                if (changeOption.ToLower() == "yes")
                {
                    Console.WriteLine("Enter the new pass code");
                    var newCode = Console.ReadLine();
                    Console.WriteLine("Pass code changed successfully");
                }
            }
            else
            {
                Console.WriteLine("Not Authenticated");
            }
        }
    }
}
