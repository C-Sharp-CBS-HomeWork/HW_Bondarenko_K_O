using System;

namespace Task_13_3
{
    class Author
    {
        private string text;

        public Author(string text)
        {
            this.text = text;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Автор: " + text);
            Console.ResetColor();
        }        
    }
}
