using System;

namespace Task_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Введите логин");
            user.Login = Console.ReadLine();

            Console.WriteLine("Введите Ваше имя");
            user.Name = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию ");
            user.Surname = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст ");
            user.Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Логин " + user.Login);
            Console.WriteLine("Имя " + user.Name);
            Console.WriteLine("Фамилия " + user.Surname);
            Console.WriteLine("Возраст " + user.Age);
            Console.WriteLine("Дата заполнения анкеты " + user.CreateTime);
        }
    }
}
