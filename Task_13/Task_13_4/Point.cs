using System;
using System.Collections.Generic;
using System.Text;

namespace Task_13_4
{
    public class Point
    {
        private int x, y;
        private string name;
        public Point(int x,int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }
    }
}
