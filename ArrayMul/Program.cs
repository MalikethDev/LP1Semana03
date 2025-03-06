using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // The user provides 6 arguments
            if (args.Length != 6)
            {
                Console.WriteLine("You must provide 6 arguments");
                return;
            }

            // Matrix A2x2 as float
            // User provides the values for the matrix in cmd
            float[,] matrixA = {
                { float.Parse(args[0], CultureInfo.InvariantCulture), float.Parse(args[1], CultureInfo.InvariantCulture) },
                { float.Parse(args[2], CultureInfo.InvariantCulture), float.Parse(args[3], CultureInfo.InvariantCulture) }
            };

            // Matrix B2x1 as float
            // User provides the values for the matrix in cmd
            float[,] vectorB = {
                { float.Parse(args[4], CultureInfo.InvariantCulture) },
                { float.Parse(args[5], CultureInfo.InvariantCulture) }
            };

            // Multiply A2x2 by B2x1
            for (int i = 0; i < 2; i++) // Goes through the rows of matrix A
            {
                float result = 0; // Initialize the result
                for (int j = 0; j < 2; j++) // Goes through the columns of matrix A
                {
                    result += matrixA[i, j] * vectorB[j, 0]; // Multiply the values and add to the result
                }
                Console.WriteLine(result);
            }

            // Print the result with 2 decimal places
            Console.WriteLine("$| {result}:F2 |");
        }
    }
}