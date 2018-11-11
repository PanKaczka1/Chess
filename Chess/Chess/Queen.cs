using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : IPiece
    {
        public int[,] ChessBoard { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Enums.Color Color { get; set; }

        public Queen(int x, int y, Enums.Color color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
            ChessBoard = new int[8, 8];
        }

        public IPiece Move(int x, int y)
        {
            if (CanMove(x, y))
            {
                this.X = x;
                this.Y = y;
                return this;
            }
            else
            {
                throw new Exception("fdsfdsf");
            }
        }
    }
}
