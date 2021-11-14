using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15
{
    class Printer
    {
        public virtual void Print(string value)
        {
            if (this is MyClass)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Производный");                
            }
            else
            {
                Console.WriteLine("Базовый");                
            }            
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
