//2) The supporting class (with whichever name you choose) will:
//• Receive the “board” array from the driver class
//• Contain a method that prints the board based on the information passed to it
//• Contain a method that receives the game board array as input and returns if there is a
//winner and who it was

using System;
using System.Collections.Generic;
using System.Text;

namespace Mission4Assignment
{
    internal class GameTools
    {
        public void printCurrentBoard(char[] board)
        {
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine("------");
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine("------");
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
            
        }

        public char checkWin(char[] board)
        {
            // result/return of the game:
            // 'x' = X won
            // 'o' = O won
            // 'd' = draw
            // '\0' = game still in progress
            
            // set result to something other than x, o, or d so if it stays unchanged the main handles it as else
            char result = '\0';
            
            // set vairables to track whether X or O has a winning line (false by default)
            bool xWins = false;
            bool oWins = false;
            bool anyEmpty = false; //for draw chekcing or continue game
            
            // possible win combinations
            int[][] lines =
            {
                new[] {0, 1, 2},
                new[] {3, 4, 5},
                new[] {6, 7, 8},
                new[] {0, 3, 6},
                new[] {1, 4, 7},
                new[] {2, 5, 8},
                new[] {0, 4, 8},
                new[] {2, 4, 6}
            };
            
            
            // Check every possible winning line (from the array above)
            foreach (var line in lines)
            {
                int a = line[0];
                int b = line[1];
                int c = line[2];

                // If all three positions contain 'x', X wins
                if (char.ToLower(board[a]) == 'x' && char.ToLower(board[b]) == 'x' && char.ToLower(board[c]) == 'x')
                    xWins = true;

                // If all three positions contain 'o', O wins
                if (char.ToLower(board[a]) == 'o' && char.ToLower(board[b]) == 'o' && char.ToLower(board[c]) == 'o')
                    oWins = true;
            }

            // Decide the result based on priority
            if (xWins)
            {
                // X wins take priority
                result = 'x';
            }
            else if (oWins)
            {
                // O wins if X did not win
                result = 'o';
            }
            else
            {
                // If any spot is not 'x' or 'o', the game is still going
                foreach (var spot in board)
                {
                    if (char.ToLower(spot) != 'x' && char.ToLower(spot) != 'o')
                    {
                        anyEmpty = true;
                        break;
                    }
                }

                // No empty spots and no winner means a draw
                if (!anyEmpty)
                {
                    result = 'd';
                }
            }

            // Single return point as requested
            return result;
        }

    }
}
