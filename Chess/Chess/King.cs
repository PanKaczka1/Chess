using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King : IPiece
    {
        public int[,] ChessBoard { get; set; }
        public int[,] OccupiedFields { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Enums.Color Color { get; set; }

        public King(int x, int y, Enums.Color color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
            ChessBoard = new int[8, 8];
        }

        public void GetAvailableMoves()
        {
            ChessBoard[X + 1, Y] = 1;
            ChessBoard[X + 1, Y + 1] = 1;
            ChessBoard[X + 1, Y - 1] = 1;
            ChessBoard[X - 1, Y] = 1;
            ChessBoard[X - 1, Y + 1] = 1;
            ChessBoard[X - 1, Y - 1] = 1;
            ChessBoard[X, Y + 1] = 1;
            ChessBoard[X, Y - 1] = 1;
        }
        public IPiece Move(int x, int y)
        {
            GetAvailableMoves();
            if (ChessBoard[x, y] == 1)
            {
                this.X = x;
                this.Y = y;
                return this;
            }
            else
            {
                throw new Exception("fdsf");
            }
        }
    }
}
