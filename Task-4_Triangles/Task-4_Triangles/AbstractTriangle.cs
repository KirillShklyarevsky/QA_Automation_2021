using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    public abstract class AbstractTriangle
    {
        public Point FirstPoint { get; }

        public Point SecondPoint { get; }

        public Point ThirdPoint { get; }

        public Colors Color { get; }

        public double FirstSideLength { get; }

        public double SecondSideLength { get; }

        public double ThirdSideLength { get; }

        public AbstractTriangle(Point firstPoint, Point secondPoint, Point thirdPoint, Colors color)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;
            Color = color;

            FirstSideLength = FirstPoint.DistanceBetweenTwoPoints(SecondPoint);
            SecondSideLength = FirstPoint.DistanceBetweenTwoPoints(ThirdPoint);
            ThirdSideLength = SecondPoint.DistanceBetweenTwoPoints(ThirdPoint);

            if (!CheckingForTriangle())
            {
                throw new ArgumentException("Incorrect points");
            }
        }

        private bool CheckingForTriangle()
        {
            return FirstSideLength + SecondSideLength > ThirdSideLength && FirstSideLength + ThirdSideLength > SecondSideLength && SecondSideLength + ThirdSideLength > FirstSideLength;
        }

        public double CalculateAreaOfTriangle()
        {
            return Math.Abs(((FirstPoint.X - ThirdPoint.X) * (SecondPoint.Y - ThirdPoint.Y) - (SecondPoint.X - ThirdPoint.X) * (FirstPoint.Y - ThirdPoint.Y)) / 2);
        }
    }
}
