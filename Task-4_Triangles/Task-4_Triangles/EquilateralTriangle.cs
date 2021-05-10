using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class EquilateralTriangle : AbstractTriangle
    {
        public EquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint, Colors color) 
                                  : base(firstPoint, secondPoint, thirdPoint, color) { }

        public static bool CheckingForEquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double FirstSideLength = firstPoint.DistanceBetweenTwoPoints(secondPoint);
            double SecondSideLength = firstPoint.DistanceBetweenTwoPoints(thirdPoint);
            double ThirdSideLength = secondPoint.DistanceBetweenTwoPoints(thirdPoint);

            return (FirstSideLength == SecondSideLength && ThirdSideLength == FirstSideLength);
        }
    }
}
