using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    static class MainMenu
    {
        public static void DrawMenu()
        {
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 3);
            Console.WriteLine("        CCCCCCCCCCCCChhhhhhh                                                                   ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 4);
            Console.WriteLine("     CCC::::::::::::Ch:::::h                                                                   ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2 , 5);
            Console.WriteLine("   CC:::::::::::::::Ch:::::h                                                                   ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 6);
            Console.WriteLine("  C:::::CCCCCCCC::::Ch:::::h                                                                   ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 7);
            Console.WriteLine(" C:::::C       CCCCCC h::::h hhhhh           eeeeeeeeeeee        ssssssssss       ssssssssss   ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 8);
            Console.WriteLine("C:::::C               h::::hh:::::hhh      ee::::::::::::ee    ss::::::::::s    ss::::::::::s  ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 9);
            Console.WriteLine("C:::::C               h::::::::::::::hh   e::::::eeeee:::::eess:::::::::::::s ss:::::::::::::s ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 10);
            Console.WriteLine("C:::::C               h:::::::hhh::::::h e::::::e     e:::::es::::::ssss:::::ss::::::ssss:::::s");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 11);
            Console.WriteLine("C:::::C               h::::::h   h::::::he:::::::eeeee::::::e s:::::s  ssssss  s:::::s  ssssss ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 12);
            Console.WriteLine("C:::::C               h:::::h     h:::::he:::::::::::::::::e    s::::::s         s::::::s      ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 13);
            Console.WriteLine("C:::::C               h:::::h     h:::::he::::::eeeeeeeeeee        s::::::s         s::::::s   ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 14);
            Console.WriteLine(" C:::::C       CCCCCC h:::::h     h:::::he:::::::e           ssssss   s:::::s ssssss   s:::::s ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 15);
            Console.WriteLine("  C:::::CCCCCCCC::::C h:::::h     h:::::he::::::::e          s:::::ssss::::::ss:::::ssss::::::s");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 16);
            Console.WriteLine("   CC:::::::::::::::C h:::::h     h:::::h e::::::::eeeeeeee  s::::::::::::::s s::::::::::::::s ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 17);
            Console.WriteLine("     CCC::::::::::::C h:::::h     h:::::h  ee:::::::::::::e   s:::::::::::ss   s:::::::::::ss  ");
            Console.SetCursorPosition((Console.WindowWidth - 95) / 2, 18);
            Console.WriteLine("        CCCCCCCCCCCCC hhhhhhh     hhhhhhh    eeeeeeeeeeeeee    sssssssssss      sssssssssss    ");
            Console.SetCursorPosition((Console.WindowWidth - 8) / 2, 22);
            Console.WriteLine("New Game");
            Console.SetCursorPosition((Console.WindowWidth - 4) / 2, 24);
            Console.WriteLine("Exit");
        }

        public static bool ChoseMenuOption()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition((Console.WindowWidth - 11) / 2, 22);
            Console.Write(">");
            while (true)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if(Console.CursorLeft == (Console.WindowWidth - 10) / 2)
                        {
                            Console.SetCursorPosition((Console.WindowWidth - 11) / 2, 22);
                            Console.Write(" ");
                            Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
                            Console.Write(">");
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
                            Console.Write(" ");
                            Console.SetCursorPosition((Console.WindowWidth - 11) / 2, 22);
                            Console.Write(">");
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        if (Console.CursorLeft == (Console.WindowWidth - 10) / 2)
                        {
                            Console.SetCursorPosition((Console.WindowWidth - 11) / 2, 22);
                            Console.Write(" ");
                            Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
                            Console.Write(">");
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
                            Console.Write(" ");
                            Console.SetCursorPosition((Console.WindowWidth - 11) / 2, 22);
                            Console.Write(">");
                            break;
                        }
                    case ConsoleKey.Enter:
                        if(Console.CursorLeft == (Console.WindowWidth - 10) / 2)
                        {
                            Console.CursorVisible = true;
                            return true;
                        }
                        else
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
    }
}
