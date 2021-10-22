using System;
using System.Collections.Generic;
using System.Text;

namespace Task_13_2
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle (double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }

        private double PerimeterCalculator()
        {
            double perimeter = 2 * (side1 + side2);
            return perimeter;
        }

        public double Area { get { return AreaCalculator(); } }

        public double Perimeter {  get { return PerimeterCalculator(); } }
    }
}
