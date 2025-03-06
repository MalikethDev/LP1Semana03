using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask the user for a string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Ask the user for a character
            Console.WriteLine("Enter a character:");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Print the string replacing x with the character inputed
            foreach (char c in input)
            {
                if (c == 'x')
                {
                    Console.Write(character);
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
    }
}
