using System;

namespace Task_13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string title, author, content;

            Console.Write("Введите навание книги: ");
            title = Console.ReadLine();

            Console.Write("Введите описание: ");
            content = Console.ReadLine();

            Console.Write("Введите автора: ");
            author = Console.ReadLine();

            Book book = new Book(title, content, author);

            Console.Clear();

            book.Show();
            Console.ReadKey();
        }
    }
}
