using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : IPiece
    {
        public int[,] ChessBoard { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private bool haveMoved;
        public Enum_Color.Color Color { get; set; }

        public Pawn(int x, int y, Enum_Color.Color color)
        {
            haveMoved = false;
            this.X = x;
            this.Y = y;
            this.Color = color;
            ChessBoard = new int[8,8];
        }

        private void AvailableMoves()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    ChessBoard[i,j] = 0;
                }
            }
            switch (Color)
            {
                case Enum_Color.Color.black:
                    if (haveMoved == false)
                    {
                        ChessBoard[X,Y - 1] = 1;
                        ChessBoard[X,Y - 2] = 1;
                        break;
                    }
                    else
                    {
                        ChessBoard[X,Y - 1] = 1;
                        break;
                    }
                case Enum_Color.Color.white:
                    if (haveMoved == false)
                    {
                        ChessBoard[X,Y - 1] = 1;
                        ChessBoard[X,Y - 2] = 1;
                        break;
                    }
                    else
                    {
                        ChessBoard[X,Y - 1] = 1;
                        break;
                    }
            }
        }

        public IPiece Move(int x, int y)
        {
            AvailableMoves();
            if (ChessBoard[x,y] == 1)
            {
                return this;
            }
            else
            {
                throw new Exception("meh");
            }
        }
    }
}
