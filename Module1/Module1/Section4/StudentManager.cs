namespace Section4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in you class?");
            var studentCount = int.Parse(Console.RedLine());

            var students = new string[studentCount, 2]; // Each row contains name and grade

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                students[i, 0] = Console.ReadLine();

                Console.Write("Student Grade: ");
                students[i, 1] = Console.ReadLine();
            }

            // Display student names and grades
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", students[i, 0], students[i, 1]);
            }
        }
        }
    }
}
