using System;

namespace Pow2Until
{
    public class Program
    {
        // Call method from main
        private static void Main(string[] args)
        {
            Powersof2Until5();
        }
        private static void Powersof2Until5()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
