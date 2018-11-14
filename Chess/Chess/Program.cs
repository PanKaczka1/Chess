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
            View.DrawChessBoard();
            Console.SetCursorPosition(3, 1);
            Console.Write("X");
            ChessBoard chessBoard = new ChessBoard();
            Console.SetCursorPosition(3, 1);
            Console.ReadKey();
        }
    }
}

