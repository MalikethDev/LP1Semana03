using System;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Ask the user to input Rock, Paper or Scissors
            Console.WriteLine("Player 1, enter Rock, Paper or Scissors:");
            string player1Input = Console.ReadLine();

            // Ask the user to input Rock, Paper or Scissors
            Console.WriteLine("Player 2, enter Rock, Paper or Scissors:");
            string player2Input = Console.ReadLine();

            // Convert the input to the GameItem enum
            GameItem player1 = Enum.Parse<GameItem>(player1Input, true);
            GameItem player2 = Enum.Parse<GameItem>(player2Input, true);
            
            // Call the RockPaperScissors method and store the result in a variable
            GameStatus result = RockPaperScissors(player1, player2);

            // Use a switch statement to print the result
            switch (result)
            {
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
            }

        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            GameStatus result = GameStatus.Draw; // Initialize the as Draw by default

            if (player1 == player2)
            {
                return GameStatus.Draw; // Draw
            }

            // Check the winning conditions
            // Rock beats Scissors, Scissors beats Paper, Paper beats Rock
            if ((player1 == GameItem.Rock && player2 == GameItem.Scissors) ||
                     (player1 == GameItem.Scissors && player2 == GameItem.Paper) ||
                     (player1 == GameItem.Paper && player2 == GameItem.Rock))
            {
                return GameStatus.Player1Wins; // Player 1 wins
            }
            
            else
            {
                return GameStatus.Player2Wins; // Player 2 wins
            }
        }
    }
}