using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_3
{
    class Car : Vehicle
    {
        String model;

        public Car(int price, int speed, int date, string model) : base(price, speed, date)
        {
            this.model = model;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n Модель: {model}";
        }
    }
}
