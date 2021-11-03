using System;

namespace Task_13_3
{
    class Content
    {
        private string text;

        public Content(string text)
        {
            this.text = text;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("описание: " + text);
            Console.ResetColor();
        }
    }
}
