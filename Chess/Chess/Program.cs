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
            View.DrawChessBoard();
            View.SetPieces(chessBoard);
            while(true)
            {
                View.MoveFocus(chessBoard, (Console.WindowWidth - 72) / 2 + 3, 3);
            }
            Console.ReadKey();
        }
    }
}

