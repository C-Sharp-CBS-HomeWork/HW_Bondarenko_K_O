using System;

namespace Task_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите первую сторону прямоугольника: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Укажите вторую сторону прямоугольника: ");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine("Периметр равен: " + rectangle.Perimeter);
            Console.WriteLine("Площадь равна: " + rectangle.Area);

            Console.ReadKey();
        }
    }
}
