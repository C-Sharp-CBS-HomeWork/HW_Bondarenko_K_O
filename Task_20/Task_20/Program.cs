using System;

namespace Task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите год");
            int year = int.Parse(Console.ReadLine());

            DateTime birthday = new DateTime(year, month, day);
            DateTime now = DateTime.Now;

            TimeSpan ts = birthday - now;
            int days = (int)ts.TotalDays;

            Console.WriteLine("Осталось до следующего дня рождения " + days + " дней");
        }
    }
}
