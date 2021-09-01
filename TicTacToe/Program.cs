using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to TicTacToe Game!");
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Board();
            ticTacToe.Selection();
            ticTacToe.GameBoard();
           
        }
    }
}
