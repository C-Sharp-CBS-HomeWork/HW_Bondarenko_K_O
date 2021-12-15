using System;

namespace Task_20_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string stroka = Console.ReadLine();

            Console.WriteLine("Выберите цвет :");
            Console.WriteLine("1 - Красный");
            Console.WriteLine("1 - Желтый");
            Console.WriteLine("1 - Зеленый");

            int color = int.Parse(Console.ReadLine());
            Console.Clear();

            Class1.Print(stroka, color);

            Console.ReadKey();
        }
    }
}
