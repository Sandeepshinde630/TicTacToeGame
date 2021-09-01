using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
   public class TicTacToe
    {
        char[] board = new char[10];
        public char[] Board()
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
