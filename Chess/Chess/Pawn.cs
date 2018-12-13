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
        public int[,] OccupiedFields { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private bool haveMoved;
        public Enums.Color Color { get; set; }

        public Pawn(int x, int y, Enums.Color color)
        {
            haveMoved = false;
            this.X = x;
            this.Y = y;
            this.Color = color;
            ChessBoard = new int[8,8];
        }

        public void GetAvailableMoves()
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
                case Enums.Color.White:
                    if (haveMoved == false)
                    {
                        ChessBoard[X,Y - 1] = 1;
                        if (OccupiedFields[X, Y - 1] == 0)
                            ChessBoard[X, Y - 2] = 1;
                        break;
                    }
                    else
                    {
                        ChessBoard[X,Y - 1] = 1;
                        break;
                    }
                case Enums.Color.Black:
                    if (haveMoved == false)
                    {
                        ChessBoard[X,Y + 1] = 1;
                        if (OccupiedFields[X, Y + 1] == 0) 
                            ChessBoard[X,Y + 2] = 1;
                        break;
                    }
                    else
                    {
                        ChessBoard[X,Y + 1] = 1;
                        break;
                    }
            }
        }

        public void Move(int x, int y)
        {
            haveMoved = true;
            this.X = x;
            this.Y = y;
        }
        public bool CanMove(int x , int y)
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
