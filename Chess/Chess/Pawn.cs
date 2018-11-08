using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : IPiece
    {
        public int X { get; set; }
        public int Y { get; set; }
        private bool haveMoved;

        public Pawn(int x, int y)
        {
            haveMoved = false;
            this.X = x;
            this.Y = y;

        }

        private bool CanMove(int x, int y)
        {
            if (this.X != x || this.Y != y + 1)
            {
                return false;
            }
            else
            {
                return true;
            }
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
                throw new Exception("AAAAA");
            }
        }
    }
}
