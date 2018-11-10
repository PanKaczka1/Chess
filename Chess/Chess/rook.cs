using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Rook : IPiece
    {
        public int[,] ChessBoard { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Enum_Color.Color Color { get; set; }

        public Rook(int x, int y, Enum_Color.Color color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
            ChessBoard = new int[8, 8];
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
            for (int i = 0; i < 8; i++) 
            {
                ChessBoard[X,i] = 1;
            }
            for (int i = 0; i < 8; i++)
            {
                ChessBoard[i,Y] = 1;
            }
        }

        public IPiece Move(int x, int y)
        {
            if (ChessBoard[x, y] == 1)
            {
                return this;
            }
            else
            {
                throw new Exception("AAAA");
            }
        }
    }
}
