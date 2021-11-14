using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15
{
    class MyClass : Printer
    {
    }

    class RedPrinter : Printer
    {
        ConsoleColor Color => ConsoleColor.Red;
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }
    }
}
