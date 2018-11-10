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
            Board[0,0] = new Rook(0, 0, Enum_Color.Color.black);
            Board[1,0] = new Knight(1, 0, Enum_Color.Color.black);
            Board[2,0] = new Bishop(2, 0, Enum_Color.Color.black);
            Board[3,0] = new Queen(3, 0, Enum_Color.Color.black);
            Board[4,0] = new King(4, 0, Enum_Color.Color.black);
            Board[5,0] = new Bishop(5, 0, Enum_Color.Color.black);
            Board[6,0] = new Knight(6, 0, Enum_Color.Color.black);
            Board[7,0] = new Rook(7, 0, Enum_Color.Color.black);
                   
            Board[0,7] = new Rook(0, 7, Enum_Color.Color.white);
            Board[1,7] = new Knight(1, 7, Enum_Color.Color.white);
            Board[2,7] = new Bishop(2, 7, Enum_Color.Color.white);
            Board[3,7] = new King(3, 7, Enum_Color.Color.white);
            Board[4,7] = new Queen(4, 7, Enum_Color.Color.white);
            Board[5,7] = new Bishop(5, 7, Enum_Color.Color.white);
            Board[6,7] = new Knight(6, 7, Enum_Color.Color.white);
            Board[7,7] = new Rook(7, 7, Enum_Color.Color.white);

            for (int i = 0; i < 8; i++)
            {
                Board[1,i] = new Pawn(1, i, Enum_Color.Color.black);
                Board[6,i] = new Pawn(6, i, Enum_Color.Color.white);
            }
        }

        public void Move(int x, int y, IPiece piece)
        {
            if (Board[x, y] != null)
            {
                if(Board[x,y].Color != piece.Color)
                {
                    piece.Move(x, y);
                    Board[x, y] = piece;
                }
                else
                {
                    throw new Exception("fdsfsdf");
                }
            }
            else
            {
                piece.Move(x, y);
                Board[x, y] = piece;
            }
        }
    }
}
