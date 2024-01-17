namespace Module1
{
    internal class MultipleChoice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            Console.WriteLine("How many pets do you have?");
            var pets = Console.ReadLine();

            Console.WriteLine("What is your pets name?");
            var petName = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("You were born in: {0}", month);
            Console.WriteLine("You have: {0} pets", pets);
            Console.WriteLine("Your pets name is: {0}", petName);
        }
    }
}
