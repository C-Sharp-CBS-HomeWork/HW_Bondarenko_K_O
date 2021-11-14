using System;

namespace Task_14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            string surname = Console.ReadLine();

            Employee employee = new Employee(name, surname);
            employee.Salary();

            Console.ReadKey();
        }
    }
}
