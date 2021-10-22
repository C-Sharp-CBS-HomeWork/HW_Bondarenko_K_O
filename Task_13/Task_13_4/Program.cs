using System;

namespace Task_13_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point radius, kol_storon, name;
            //Console.Write("Введите радиус описаной окружности: ");
            //radius =Point.Parse(Console.ReadLine());

            //Console.Write("Введите количество правильного многоугольника: ");
            //kol_storon = int.Parse(Console.ReadLine());

            //Console.Write("Введите название правильного многоугольника: ");
            //string name = Console.ReadLine();

            Point p1, p2, p3, p4, p5;

            p1 = new Point(0,0,"A");
            p2 = new Point(1, 2,"B");
            p3 = new Point(2, 0,"C");
            p4 = new Point(1, 2,"D");
            p5 = new Point(3, 2,"E");


            Figure figure = new Figure(p1,p2,p3);
            figure.PerimeterCalculator();

            figure = new Figure(p1, p2, p3, p4);
            figure.PerimeterCalculator();

            figure = new Figure(p1, p2, p3, p4, p5);
            figure.PerimeterCalculator();
        }
    }
}
