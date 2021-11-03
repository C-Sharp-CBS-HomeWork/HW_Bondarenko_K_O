using System;

namespace Task_13_4
{
    public class Figure
    {
        Point[] points;
        public string Name()
        {
            string q = "";
            for (int i = 0; i < points.Length; i++)
            {
                q += points[i].Name;
            }

            return q;
        }
                
                     
        
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;
        }

        double LengthSide(Point A, Point B)
        {
            double res = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return res;
        }

        public void PerimeterCalculator()
        {
            double res =0;
            string q = "";

            for (int i =0; i< points.Length -1; i++)
            {
                res += LengthSide(points[i], points[i+1]);
            }

            res += LengthSide(points[points.Length - 1], points[0]);

            Console.WriteLine("Периметр фигуры " + Name() + " равен: " + res);
        }
    }
}
