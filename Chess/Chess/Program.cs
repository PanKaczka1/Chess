using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard();
            chessBoard.Move(5, 5, chessBoard.Board[5, 6]);
            chessBoard.Move(5, 4, chessBoard.Board[5, 5]);
            chessBoard.Move(5, 3, chessBoard.Board[5, 4]);
            chessBoard.Move(5, 2, chessBoard.Board[5, 3]);
            chessBoard.Move(5, 1, chessBoard.Board[5, 2]);
            Console.ReadKey();
        }
    }
}
