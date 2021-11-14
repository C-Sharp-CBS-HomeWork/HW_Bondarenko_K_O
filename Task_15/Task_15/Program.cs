using System;

namespace Task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = "qwerty";            

            Printer printer = new Printer();
            printer.Print(q);

            MyClass my = new MyClass();
            my.Print(q);

            RedPrinter redPrinter = new RedPrinter();
            ((Printer)redPrinter).Print(q);

            Console.ReadKey();
        }
    }
}
