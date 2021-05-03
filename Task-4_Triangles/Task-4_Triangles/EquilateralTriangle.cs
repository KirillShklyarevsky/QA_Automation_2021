using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class EquilateralTriangle : AbstractTriangle, ICalculateAreaOfTriangle
    {
        private const string _color = "Red";

        public string Color { get; }

        public EquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint) : base(firstPoint, secondPoint, thirdPoint) { }

        private bool CheckingForEquilateralTriangle()
        {
            return (FirstSideLength == SecondSideLength && ThirdSideLength == FirstSideLength);
        }

        public double CalculateAreaOfTriangle()
        {
            return (Math.Sqrt(3) * Math.Pow(FirstSideLength,2)) / 4;
        }
    }
}
