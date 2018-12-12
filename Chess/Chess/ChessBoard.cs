using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessBoard
    {
        public IPiece[,] Board { get; set; }
        
        public ChessBoard()
        {
            Board = new IPiece[8, 8];
            Board[0,0] = new Rook(0, 0, Enums.Color.Black);
            Board[1,0] = new Knight(1, 0, Enums.Color.Black);
            Board[2,0] = new Bishop(2, 0, Enums.Color.Black);
            Board[3,0] = new Queen(3, 0, Enums.Color.Black);
            Board[4,0] = new King(4, 0, Enums.Color.Black);
            Board[5,0] = new Bishop(5, 0, Enums.Color.Black);
            Board[6,0] = new Knight(6, 0, Enums.Color.Black);
            Board[7,0] = new Rook(7, 0, Enums.Color.Black);
                   
            Board[0,7] = new Rook(0, 7, Enums.Color.White);
            Board[1,7] = new Knight(1, 7, Enums.Color.White);
            Board[2,7] = new Bishop(2, 7, Enums.Color.White);
            Board[3,7] = new King(3, 7, Enums.Color.White);
            Board[4,7] = new Queen(4, 7, Enums.Color.White);
            Board[5,7] = new Bishop(5, 7, Enums.Color.White);
            Board[6,7] = new Knight(6, 7, Enums.Color.White);
            Board[7,7] = new Rook(7, 7, Enums.Color.White);

            for (int i = 0; i < 8; i++)
            {
                Board[i,1] = new Pawn(i, 1, Enums.Color.Black);
                Board[i,6] = new Pawn(i, 6, Enums.Color.White);
            }
        }

        private bool IsKingInCheck(IPiece piece)
        {
            int i, j, k, l;
            for (i = 0; i < 8; i++) 
                for (j = 0; j < 8; j++) 
                {
                    if (Board[i, j] is King && Board[i, j].Color == piece.Color) 
                    {
                        for (k = 0; k < 8; k++)
                            for (l = 0; l < 8; l++)
                            {
                                if (Board[k,l] != null && Board[k, l].Color != piece.Color)
                                {
                                    Board[k, l].OccupiedFields = IsOccupied();
                                    Board[k, l].GetAvailableMoves();
                                    if (Board[k, l].ChessBoard[i, j] == 1)
                                    {
                                        return true;
                                    }
                                }
                            }
                    }
                }
            return false;
        }

        private int[,] IsOccupied()
        {
            int[,] chessBoard = new int[8,8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Board[i, j] != null)
                    {
                        chessBoard[i, j] = 1;
                    }
                    else
                    {
                        chessBoard[i, j] = 0;
                    }
                }
            return chessBoard;

        }

        public bool Move(int x, int y, IPiece piece)
        {
            IPiece tmp = piece;
            IPiece tmp2 = Board[x, y];
            piece.OccupiedFields = IsOccupied();
            if (Board[x, y] != null)
            {
                if(Board[x,y].Color != piece.Color)
                {
                    if (piece.Move(x, y) == true)
                    {
                        Board[piece.X, piece.Y] = null;
                        piece.Move(x, y);
                        Board[x, y] = piece;
                    }
                    else
                    {
                        return false;
                    }
                    //if (IsKingInCheck(piece))
                    //{
                    //    Board[tmp.X, tmp.Y] = piece;
                    //    piece.Move(tmp.X, tmp.Y);
                    //    Board[x, y] = tmp2;
                    //}
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if(piece.Move(x,y) == true)
                {
                    Board[piece.X, piece.Y] = null;
                    piece.Move(x, y);
                    Board[x, y] = piece;
                }
                else
                {
                    return false;
                }
                //if (IsKingInCheck(piece))
                //{
                //    Board[tmp.X, tmp.Y] = piece;
                //    piece.Move(tmp.X, tmp.Y);
                //    Board[x, y] = tmp2;
                //}
                return true;
            }
        }
    }
}
