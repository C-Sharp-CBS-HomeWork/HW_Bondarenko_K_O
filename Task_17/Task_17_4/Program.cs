using System;

namespace Task_17_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Add();
            string tovar;
            int index;

            Console.Clear();

            Console.WriteLine("Введите имя товара для поиска");
            tovar = Console.ReadLine();

            Console.WriteLine(store[tovar]);

            Console.WriteLine();

            Console.WriteLine("Введите индекс товара для поиска");
            index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(store[index]);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(store[i]);
            //}

            Console.ReadKey();
        }
    }
}
