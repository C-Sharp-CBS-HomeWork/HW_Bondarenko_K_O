using System;
using System.Collections.Generic;
using System.Text;

namespace Task_20_2
{
    static class Class1
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    }

                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(stroka);
                        Console.ResetColor();
                        break;
                    }
            }
        }
    }
}
