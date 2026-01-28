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
            return result;
        }

    }
}
