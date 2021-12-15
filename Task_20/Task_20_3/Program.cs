using System;

namespace Task_20_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите должность");
            Console.WriteLine("1 - Разнорабочий");
            Console.WriteLine("2 - Охрана");
            Console.WriteLine("3 - Директор");
            int i = int.Parse(Console.ReadLine());

            Console.Write("Введите кол-во отработаных часов: ");
            int hour = int.Parse(Console.ReadLine());

            Accountant accountant = new Accountant();
            switch (i)
            {
                case 1:
                    {
                        accountant.AskForBonus(Post.handyman, hour);
                        break;
                    }
                case 2:
                    {
                        accountant.AskForBonus(Post.security, hour);
                        break;
                    }
                case 3:
                    {
                        accountant.AskForBonus(Post.director, hour);
                        break;
                    }
            }
        }
    }
}
enum Post
{
    handyman = 164,
    security = 180,
    director = 160
}