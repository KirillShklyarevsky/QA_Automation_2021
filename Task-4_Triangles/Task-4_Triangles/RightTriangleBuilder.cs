using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class RightTriangleBuilder : TriangleBulder
    {
        public override AbstractTriangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            if (RightTriangle.CheckingForRightTriangle(firstPoint, secondPoint, thirdPoint))
            {
                return new RightTriangle(firstPoint, secondPoint, thirdPoint, Colors.Green);
            }
            else
            {
                return Successor.Build(firstPoint, secondPoint, thirdPoint);
            }
        }
    }
}
