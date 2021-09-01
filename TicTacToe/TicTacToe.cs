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
            else
            {
                Console.WriteLine("Invalid User Input");
            }
        }
        public void GameBoard()
        {
            Console.WriteLine("|" + board[1] + "|" + board[2] + "|" + board[3] + "|");
            Console.WriteLine("-------");
            Console.WriteLine("|" + board[4] + "|" + board[5] + "|" + board[6] + "|");
            Console.WriteLine("-------");
            Console.WriteLine("|" + board[7] + "|" + board[8] + "|" + board[9] + "|");
        }
    }
}
