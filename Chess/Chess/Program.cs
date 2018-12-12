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
            Console.Title = "Chess";
            Console.OutputEncoding = Encoding.UTF8;
            MainMenu.DrawMenu();
            Console.Clear();
            MainMenu.DrawMenu();
            MainMenu.ChoseMenuOption();
            Console.Clear();
            ChessBoard chessBoard = new ChessBoard();
            View.DrawChessBoard();
            View.SetPieces(chessBoard, (Console.WindowWidth - 72) / 2 + 3, 3);
            View.MoveFocus(chessBoard, (Console.WindowWidth - 72) / 2 + 3, 3);
            Console.ReadKey();

        }
    }
}