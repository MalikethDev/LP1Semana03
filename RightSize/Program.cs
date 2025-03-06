using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Using foreach
            // Print the arguments in cmd with lenght superiror to 3
            foreach (string s in args)
            {
                if (s.Length > 3)
                {
                    Console.WriteLine(s);
                }
            } 
        }
    }
}
