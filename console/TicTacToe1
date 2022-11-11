using System;

namespace ca1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");

            // Set up the game board
            string[,] gameBoard = new string[3, 3];
            gameBoard[0, 0] = " ";
            gameBoard[0, 1] = " ";
            gameBoard[0, 2] = " ";
            gameBoard[1, 0] = " ";
            gameBoard[1, 1] = " ";
            gameBoard[1, 2] = " ";
            gameBoard[2, 0] = " ";
            gameBoard[2, 1] = " ";
            gameBoard[2, 2] = " ";

            // Display the game board
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(String.Format("{0} | {1} | {2}", gameBoard[i, 0], gameBoard[i, 1], gameBoard[i, 2]));
            }

            // Player 1 goes first
            bool player1Turn = true;
            string player1Marker = "X";
            string player2Marker = "O";
            string currentMarker = player1Marker;

            // Loop until the game is over
            while (true)
            {
                // Get the player's next move
                int row, col;
                Console.WriteLine(String.Format("It is Player {0}'s turn.", player1Turn ? 1 : 2));
                Console.Write("Choose a square: ");
                var input = Console.ReadLine();

                // Make sure the input is valid
                if (!int.TryParse(input, out int square) || square < 1 || square > 9)
                {
                    Console.WriteLine("That is not a valid move.");
                    continue;
                }

                // Convert the user's input into row/column coordinates
                row = (square - 1) / 3;
                col = (square - 1) % 3;

                // Make sure the chosen square is empty
                if (gameBoard[row, col] != " ")
                {
                    Console.WriteLine("That square is already taken.");
                    continue;
                }

                // Place the player's marker in the chosen square
                gameBoard[row, col] = currentMarker;

                // Display the game board
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(String.Format("{0} | {1} | {2}", gameBoard[i, 0], gameBoard[i, 1], gameBoard[i, 2]));
                }

                // Check for a winner
                bool winner = false;
                if (gameBoard[0, 0] == currentMarker && gameBoard[0, 1] == currentMarker && gameBoard[0, 2] == currentMarker)
                {
                    winner = true;
                }
                else if (gameBoard[1, 0] == currentMarker && gameBoard[1, 1] == currentMarker && gameBoard[1, 2] == currentMarker)
                {
                    winner = true;
                }
                else if (gameBoard[2, 0] == currentMarker && gameBoard[2, 1] == currentMarker && gameBoard[2, 2] == currentMarker)
                {
                    winner = true;
                }
                else if (gameBoard[0, 0] == currentMarker && gameBoard[1, 0] == currentMarker && gameBoard[2, 0] == currentMarker)
                {
                    winner = true;
                }
                else if (gameBoard[0, 1] == currentMarker && gameBoard[1, 1] == currentMarker && gameBoard[2, 1] == currentMarker)
                {
                    winner = true;
                }
                else if (gameBoard[0, 2] == currentMarker && gameBoard[1, 2] == currentMarker && gameBoard[2, 2] == currentMarker)
                {
                    winner = true;
                }
                else if (gameBoard[0, 0] == currentMarker && gameBoard[1, 1] == currentMarker && gameBoard[2, 2] == currentMarker)
                {
                    winner = true;
                }
                else if (gameBoard[0, 2] == currentMarker && gameBoard[1, 1] == currentMarker && gameBoard[2, 0] == currentMarker)
                {
                    winner = true;
                }

                if (winner)
                {
                    Console.WriteLine(String.Format("Player {0} wins!", player1Turn ? 1 : 2));
                    break;
                }

                // Check for a draw
                bool draw = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (gameBoard[i, j] == " ")
                        {
                            draw = false;
                            break;
                        }
                    }

                    if (!draw)
                    {
                        break;
                    }
                }

                if (draw)
                {
                    Console.WriteLine("The game ended in a draw.");
                    break;
                }

                // Swap players
                player1Turn = !player1Turn;
                currentMarker = player1Turn ? player1Marker : player2Marker;
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}
