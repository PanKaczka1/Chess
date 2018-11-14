using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Knight : IPiece
    {
        public int[,] ChessBoard { get; set; }
        public int[,] OccupiedFields { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Enums.Color Color { get; set; }

        public Knight(int x, int y, Enums.Color color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
            ChessBoard = new int[8, 8];
        }

        public void AvailableMoves()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    ChessBoard[i, j] = 0;
                }
            }
            if (X + 1 <= 7 && Y + 2 <= 7) 
            {
                ChessBoard[X + 1, Y + 2] = 1;
            }
            if (X + 1 <= 7 && Y - 2 <= 7)
            {
                ChessBoard[X + 1, Y - 2] = 1;
            }
            if (X + 2 <= 7 && Y - 1 <= 7)
            {
                ChessBoard[X + 2, Y - 1] = 1;
            }
            if (X + 2 <= 7 && Y + 1 <= 7)
            {
                ChessBoard[X + 2, Y + 1] = 1;
            }
            if (X - 2 <= 7 && Y + 1 <= 7)
            {
                ChessBoard[X - 2, Y + 1] = 1;
            }
            if (X - 2 <= 7 && Y - 1 <= 7)
            {
                ChessBoard[X - 2, Y - 1] = 1;
            }
            if (X - 1 <= 7 && Y + 2 <= 7)
            {
                ChessBoard[X - 1, Y + 2] = 1;
            }
            if (X - 1 <= 7 && Y - 2 <= 7)
            {
                ChessBoard[X - 1, Y - 2] = 1;
            }
        }

        public IPiece Move(int x, int y)
        {
            AvailableMoves();
            if (ChessBoard[x, y] == 1) 
            {
                this.X = x;
                this.Y = y;
                return this;
            }
            else
            {
                throw new Exception("fdsfsdf");
            }
        }
    }
}
