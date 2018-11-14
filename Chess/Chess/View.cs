using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    static class View
    {
        static public void DrawChessBoard()
        {
            int i, j, k;
            for (i = 0; i < 24; i++)
            {
                k = 0;
                for (j = 0; j < 4; j++)
                {       
                    if (i % 6 > 2)  
                    {
                        Console.SetCursorPosition((Console.WindowWidth - 72)/2 + k, i + 2);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("        ");
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write("        ");
                        k += 16;
                    }
                    else
                    {
                        Console.SetCursorPosition((Console.WindowWidth - 72)/2 + k, i + 2);
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write("        ");
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write("        ");
                        k += 16;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
