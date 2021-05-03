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

        public double FirstSideLength { get; }

        public double SecondSideLength { get; }

        public double ThirdSideLength { get; }

        public AbstractTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;

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
    }
}
