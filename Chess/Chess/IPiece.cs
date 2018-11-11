﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    interface IPiece
    {
        int[,] ChessBoard { get; set; }
        int[,] OccupiedFields { get; set; }
        int X { get; set; }
        int Y { get; set; }
        Enums.Color Color { get; set; }

        IPiece Move(int x, int y);
    }
}
