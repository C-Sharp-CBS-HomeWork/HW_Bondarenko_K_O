using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_3
{
    class Plane : Vehicle
    {
        int height;
        int countPass;        

        public Plane(int price, int speed, int date, int height, int countPass) : base(price, speed, date)
        {
            this.height = height;
            this.countPass = countPass;
        }


        public override string ToString()
        {
            return base.ToString() + $"\n Высота: {height}\n Кол. Пассажиров: {countPass}";
        }
    }
}
