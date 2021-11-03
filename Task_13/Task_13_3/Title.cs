using System;

namespace Task_13_3
{
    class Title
    {
        private string text;

        public Title( string text)
        {
            this.text = text;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Название: " + text);
            Console.ResetColor();
        }
    }
}
