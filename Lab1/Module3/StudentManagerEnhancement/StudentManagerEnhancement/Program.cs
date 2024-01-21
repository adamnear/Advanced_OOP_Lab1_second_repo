namespace StudentManagerEnhancement
{
        public class MyCustomException : FormatException
        {
            public MyCustomException(string message) : base(message)
            {
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("How many students in you class?");
                    var studentCount = int.Parse(Console.ReadLine());

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
                catch (FormatException ex)
                {
                    // Handle the custom exception
                    Console.WriteLine($"Error: {ex.Message}. Please enter a valid numeric value.");
                }
                catch (MyCustomException ex)
                {
                    // Handle the custom exception
                    Console.WriteLine($"Custom Error: {ex.Message}");
                }
            }
        }
    }

