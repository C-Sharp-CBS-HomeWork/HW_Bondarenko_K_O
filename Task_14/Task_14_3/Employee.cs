using System;
using System.Collections.Generic;
using System.Text;

namespace Task_14_3
{
    class Employee
    {
        private readonly string surname;
        private readonly string name;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void Salary()
        {
            Console.WriteLine("Выберите должность: ");
            Console.WriteLine("1 - Охранник");
            Console.WriteLine("2 - Нач. Отдела");
            Console.WriteLine("3 - Зам. Директора");

            int positions = int.Parse(Console.ReadLine());
            double salary = 0;
            string positionsName = "";

            if (positions == 1)
            {
                salary = 10000;
                positionsName = "Охранник";
            }
            if (positions == 2)
            {
                salary = 20000;
                positionsName = "Нач. Отдела";
            }
            if (positions == 3)
            {
                salary = 30000;
                positionsName = "Зам. Директора";
            } 

            DateTime data = new DateTime();
            Console.WriteLine("Введите дату принятия на работу(формат ДД.ММ.ГГГГ) ");
            data = DateTime.Parse(Console.ReadLine());

            var experience = (DateTime.Now.Month - data.Month) + 12 * (DateTime.Now.Year - data.Year);                      

            if (experience < 12)
            {
                salary = salary * 1;
            }

            if ((experience >= 12) & (experience < 36))
            {
                salary = salary * 1.25;
            }

            if (experience >= 36)
            {
                salary = salary * 1.5;
            }

            double tax = salary * 0.18;

            Console.Clear();
            Console.WriteLine("Имя " + name);
            Console.WriteLine("Фвмилия " + surname);
            Console.WriteLine("Должность " + positionsName);
            Console.WriteLine("Оклад " + salary);
            Console.WriteLine("Налог " + tax);
        }
    }
}
