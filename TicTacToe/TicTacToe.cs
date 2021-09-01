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
        public void Selection()
        {
            Console.WriteLine("Choose one option X or O");
            string user = Console.ReadLine();
            string Computer;

            if (user == "X")
            {
                Computer = "O";
                Console.WriteLine(Computer);
            }
            else if (user == "O")
            {
                Computer = "X";
                Console.WriteLine(Computer);
            }
        }
    }
}
