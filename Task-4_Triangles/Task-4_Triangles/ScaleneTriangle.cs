using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class ScaleneTriangle : AbstractTriangle, ICalculateAreaOfTriangle
    {
        private const string _color = "White";

        public string Color { get; }

        public ScaleneTriangle(Point firstPoint, Point secondPoint, Point thirdPoint) : base(firstPoint, secondPoint, thirdPoint) { }

        public double CalculateAreaOfTriangle()
        {
            double p = (FirstSideLength + SecondSideLength + ThirdSideLength) / 2;

            return Math.Sqrt(p * (p - FirstSideLength) * (p - SecondSideLength) * (p - ThirdSideLength));
        }
    }
}
