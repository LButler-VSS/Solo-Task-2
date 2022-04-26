using System;

namespace solo2
{
    class Program
    {
        static string letter;
        static bool pass = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade percentage (i.e. 92): ");
            int percentage = int.Parse(Console.ReadLine());

            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
                pass = false;
            }
            else
            {
                letter = "F";
                pass = false;
            }

            Console.WriteLine($"Your grade letter is {letter}");
            if (pass)
            {
                Console.WriteLine("Congratulations! You passed the course!");
            }
            else
            {
                Console.WriteLine("You didn't pass this time. You'll get it next time for sure!");
            }
        }
    }
}
