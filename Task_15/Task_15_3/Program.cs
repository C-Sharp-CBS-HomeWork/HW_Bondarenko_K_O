using System;

namespace Task_15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(15000,600,2020,10000,150);

            Car car = new Car(100,220,2012,"Ланос");

            Ship ship = new Ship(12000,90,2019,"Одесса",800);

            Console.WriteLine(plane.ToString());
            Console.WriteLine("");
            Console.WriteLine(car.ToString());
            Console.WriteLine("");
            Console.WriteLine(ship.ToString());            
        }
    }
}
