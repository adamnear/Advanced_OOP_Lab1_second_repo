namespace Section3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x <= 5; x++)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                // Combined loop with a conditional
                for (int i = (x % 2 == 0 ? 1 : 0); (x % 2 == 0 ? i >= 1 : i <= 10); i += (x % 2 == 0 ? -1 : 1))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
