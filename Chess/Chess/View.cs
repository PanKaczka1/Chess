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
            Console.BackgroundColor = ConsoleColor.White;
        }

        static public void SetPieces(ChessBoard chessBoard, int cursorLeft, int cursorTop)
        {
            Console.BackgroundColor = ConsoleColor.White;
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
                            Console.Write("\u2659");
                        }
                        else
                        {
                            Console.Write("\u265F");
                        }

                    }
                    if (chessBoard.Board[l, k] is Rook)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.Write("\u2656");
                        else
                            Console.Write("\u265C");
                    }
                    if (chessBoard.Board[l, k] is Knight)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.Write("\u2658");
                        else
                            Console.Write("\u265E");
                    }
                    if (chessBoard.Board[l, k] is Bishop)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.Write("\u2657");
                        else
                            Console.Write("\u265D");
                    }
                    if (chessBoard.Board[l, k] is Queen)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.Write("\u2655");
                        else
                            Console.Write("\u265B");
                    }
                    if (chessBoard.Board[l, k] is King)
                    {
                        Console.SetCursorPosition(j, i);
                        if (chessBoard.Board[l, k].Color == Enums.Color.White)
                            Console.Write("\u2654");
                        else
                            Console.Write("\u265A");
                    }
                    l++;
                }
                k++;
            }
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }
        

        static public void MoveFocus(ChessBoard chessBoard, int x, int y)
        {
            Enums.Color previousColor = Enums.Color.Black;
            IPiece piece = null;
            int xBoard = 0, yBoard = 0;
            while(true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        if (yBoard - 1 < 0)
                            break;
                        Console.SetCursorPosition(x, y - 3);
                        y -= 3;
                        yBoard--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (yBoard + 1 > 7)
                            break;
                        Console.SetCursorPosition(x, y + 3); 
                        y += 3;
                        yBoard++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (xBoard - 1 < 0)
                            break;
                        Console.SetCursorPosition(x - 8, y);
                        x -= 8;
                        xBoard--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (xBoard + 1 > 7)
                            break;
                        Console.SetCursorPosition(x + 8, y);
                        x += 8;
                        xBoard++;
                        break;
                    case ConsoleKey.Enter:
                        int cursorLeft = Console.CursorLeft;
                        int cursorTop = Console.CursorTop;
                        Console.SetCursorPosition(3, 10);
                        Console.Write("                   ");
                        Console.SetCursorPosition(cursorLeft, cursorTop);
                        if (piece == null)
                        {
                            if(chessBoard.Board[xBoard, yBoard] != null)
                            {
                                piece = chessBoard.Board[xBoard, yBoard];
                                if (piece.Color == previousColor)
                                {
                                    Console.SetCursorPosition(3, 10);
                                    Console.Write("Its not your piece!");
                                    piece = null;
                                }
                            }
                        }
                        else
                        {
                            cursorLeft = Console.CursorLeft;
                            cursorTop = Console.CursorTop;
                            if(chessBoard.Move(xBoard, yBoard, piece) == false)
                            {
                                Console.SetCursorPosition(3, 10);
                                Console.Write("Cant move there!");
                            }
                            else
                            {
                                chessBoard.Move(xBoard, yBoard, piece);
                                previousColor = piece.Color;
                            }
                            piece = null;
                            DrawChessBoard();
                            SetPieces(chessBoard, cursorLeft, cursorTop);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
