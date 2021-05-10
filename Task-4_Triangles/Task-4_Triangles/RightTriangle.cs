using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class RightTriangle : AbstractTriangle
    {
        public RightTriangle(Point firstPoint, Point secondPoint, Point thirdPoint, Colors color) 
                            : base(firstPoint, secondPoint, thirdPoint, color) { }

        public static bool CheckingForRightTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double FirstSideLength = firstPoint.DistanceBetweenTwoPoints(secondPoint);
            double SecondSideLength = firstPoint.DistanceBetweenTwoPoints(thirdPoint);
            double ThirdSideLength = secondPoint.DistanceBetweenTwoPoints(thirdPoint);

            return FirstSideLength * FirstSideLength + SecondSideLength * SecondSideLength == ThirdSideLength * ThirdSideLength ||
                   FirstSideLength * FirstSideLength + ThirdSideLength * ThirdSideLength == SecondSideLength * SecondSideLength ||
                   ThirdSideLength * ThirdSideLength + SecondSideLength * SecondSideLength == FirstSideLength * FirstSideLength;
        }
    }
}
