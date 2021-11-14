using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15_3
{
    class Ship : Vehicle 
    {
        int countPass;
        string port;


        public Ship(int price, int speed, int date, string port, int countPass) : base(price, speed, date)
        {
            this.countPass = countPass;
            this.port = port;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n Порт: {port}\n Кол. Пассажиров: {countPass}";
        }
    }
}
