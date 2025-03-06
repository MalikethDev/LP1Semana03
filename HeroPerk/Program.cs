using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = args[0]; // Normalize the input
            Perks selectedPerk = 0; // Default: no perks
            bool unknownPerk = false; // Invalid character

            // wasd for each perk
            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w':
                        selectedPerk |= Perks.WarpShift;
                        break;
                    case 'a':
                        selectedPerk |= Perks.DoubleJump;
                        break;
                    case 's':
                        selectedPerk |= Perks.Stealth;
                        break;
                    case 'd':
                        selectedPerk |= Perks.AutoHeal;
                        break;
                    default:
                        unknownPerk = true;
                        Console.WriteLine("Unknown perk!");
                        break;
                }
            }
            // If any unknown perk was found, stop the program
            if (unknownPerk)
            {
                return;
            }

            // Display the selected perks if any
            if (selectedPerk != 0)
            {
                Console.WriteLine(selectedPerk);
            }
            // If no perks were selected, display a message
            else
            {
                Console.WriteLine("No perks at all!");
            }
            
            // If the selected perks are Stealth and DoubleJump, display a message
            if ((selectedPerk & Perks.Stealth) != 0 && (selectedPerk & Perks.DoubleJump) != 0)
            {
                Console.WriteLine("Silent jumper!");
            }
        }
    }
}
