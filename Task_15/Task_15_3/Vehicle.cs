using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_3
{
    class Vehicle
    {
        int price;
        int speed;
        int date;

        public Vehicle( int price, int speed, int date)
        {
            this.price = price;
            this.speed = speed;
            this.date =  date;
        }


        public override string ToString()
        {
            return $" Цена: {price}\n Скорость: {speed}\n Год Выпуска:{date}";
        }

    }
}
