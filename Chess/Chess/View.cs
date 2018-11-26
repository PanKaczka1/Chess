using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    static class View
    {
        static public void DrawChessBoard()
        {
            int i, j, k;
            for (i = 0; i < 24; i++)
            {
                k = 0;
                for (j = 0; j < 4; j++)
                {
                    if (i % 6 > 2)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - 72) / 2 + k, i + 2);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("        ");
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write("        ");
                        k += 16;
                    }
                    else
                    {
                        Console.SetCursorPosition((Console.WindowWidth - 72) / 2 + k, i + 2);
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write("        ");
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("        ");
                        k += 16;
                    }
                }
                Console.Write("\n");
            }
        }

        static public void SetPieces(ChessBoard chessBoard)
        {
            int i, j, k = 0, l;
            for (i = 3; i < 27; i += 3)
            {
                l = 0;
                for (j = (Console.WindowWidth - 72) / 2 + 3; j < (Console.WindowWidth - 72) / 2 + 3 + 64; j += 8)
                {
                    if (chessBoard.Board[l, k] is Pawn)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White) 
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        Console.Write("P");

                    }
                    if (chessBoard.Board[l, k] is Rook)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.ForegroundColor = ConsoleColor.White;
                        else
                            Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("R");
                    }
                    if (chessBoard.Board[l, k] is Knight)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.ForegroundColor = ConsoleColor.White;
                        else
                            Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("N");
                    }
                    if (chessBoard.Board[l, k] is Bishop)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.ForegroundColor = ConsoleColor.White;
                        else
                            Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("B");
                    }
                    if (chessBoard.Board[l, k] is Queen)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.ForegroundColor = ConsoleColor.White;
                        else
                            Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Q");
                    }
                    if (chessBoard.Board[l, k] is King)
                    {
                        Console.SetCursorPosition(j, i);
                        if (Console.BackgroundColor == ConsoleColor.Yellow)
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.ForegroundColor = ConsoleColor.White;
                        else
                            Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("K");
                    }
                    l++;
                }
                k++;
            }
            Console.SetCursorPosition((Console.WindowWidth - 72) / 2 + 3, 3);
        }
        

        static public void MoveFocus(ChessBoard chessBoard, int x, int y)
        {
            chessBoard = chessBoard;
            IPiece piece = null;
            int xBoard = 0, yBoard = 0;
            while(true)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(x, y - 3);
                        y -= 3;
                        yBoard--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(x, y + 3); 
                        y += 3;
                        yBoard++;
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(x - 8, y);
                        x -= 8;
                        xBoard--;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(x + 8, y);
                        x += 8;
                        xBoard++;
                        break;
                    case ConsoleKey.Enter:
                        if (piece == null)
                        {
                            piece = chessBoard.Board[xBoard, yBoard];
                        }
                        else
                        {
                            chessBoard.Move(xBoard, yBoard, piece);
                            piece = null;
                            DrawChessBoard();
                            SetPieces(chessBoard);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
