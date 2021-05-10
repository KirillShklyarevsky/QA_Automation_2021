using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class EquilateralTriangleBuilder : TriangleBulder
    {
        public override AbstractTriangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            if (EquilateralTriangle.CheckingForEquilateralTriangle(firstPoint, secondPoint, thirdPoint))
            {
                return new EquilateralTriangle(firstPoint, secondPoint, thirdPoint, Colors.Red);
            }
            else
            {
                return Successor.Build(firstPoint, secondPoint, thirdPoint);
            }
        }
    }
}
