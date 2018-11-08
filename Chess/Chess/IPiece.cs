using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    interface IPiece
    {
        int X { get; set; }
        int Y { get; set; }

        IPiece Move(int x, int y);
    }
}
