using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Bishop : IPiece
    {
        public int[,] ChessBoard { get; set; }
        public int[,] OccupiedFields { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Enums.Color Color { get; set; }

        public Bishop(int x, int y, Enums.Color color)
        {
            this.X = x;
            this.Y = y;
            this.Color = color;
            ChessBoard = new int[8, 8];
        }

        public void GetAvailableMoves()
        {
            int i, j;
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    ChessBoard[i, j] = 0;
                }
            }
            for (i = X + 1; i < 8; i++) 
                for (j = Y + 1; j < 8; j++) 
                {
                    ChessBoard[i, j] = 1;
                    if (OccupiedFields[i, j] == 1)
                        break;
                }
            for (i = X - 1; i >= 0; i--)
                for (j = Y + 1; j < 8; j++)
                {
                    ChessBoard[i, j] = 1;
                    if (OccupiedFields[i, j] == 1)
                        break;
                }
            for (i = X - 1; i >= 0; i--)
                for (j = Y - 1; j >= 0; j--)
                {
                    ChessBoard[i, j] = 1;
                    if (OccupiedFields[i, j] == 1)
                        break;
                }
            for (i = X + 1; i < 8; i++)
                for (j = Y - 1; j >= 0; j--)
                {
                    ChessBoard[i, j] = 1;
                    if (OccupiedFields[i, j] == 1)
                        break;
                }
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public bool CanMove(int x, int y)
        {
            GetAvailableMoves();
            if (ChessBoard[x, y] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
