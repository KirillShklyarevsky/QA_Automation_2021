using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceBetweenTwoPoints(Point point)
        {
            return Math.Sqrt(Math.Pow((this.X - point.X),2) + Math.Pow((this.Y - point.Y), 2));
        }
    }
}
