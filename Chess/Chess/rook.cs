using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Rook : IPiece
    {
        public int X { get; set; }
        public int Y { get; set; }

        private bool CanMove(int x, int y)
        {
            if(this.X == x || this.Y == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IPiece Move(int x, int y)
        {
            if(CanMove(x,y))
            {
                this.X = x;
                this.Y = y;
                return this;
            }
            else
            {
                throw new Exception("AAAA");
            }
        }
    }
}
