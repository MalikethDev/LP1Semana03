using System;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            // Store result in a variable to return it at the end
            int result;

            if (player1 == player2)
            {
                result = 0; // Draw
            }

            // else if ensures that the program will not check the other conditions if one is true
            else if  ((player1 & GameItem.Rock) !=0 && (player2 & GameItem.Scissors) !=0 ||
                (player1 & GameItem.Scissors) !=0 && (player2 & GameItem.Paper) !=0 ||
                (player1 & GameItem.Paper) !=0 && (player2 & GameItem.Rock) !=0)
            {
                result = 1; // Player 1 wins
            }
            else
            {
                result = 2; // Player 2 wins
            }

            return result; // Return the result
        }
    }
}
