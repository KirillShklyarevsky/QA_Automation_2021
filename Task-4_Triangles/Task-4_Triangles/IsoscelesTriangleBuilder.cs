using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class IsoscelesTriangleBuilder : TriangleBulder
    {

        public override AbstractTriangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            if (IsoscelesTriangle.CheckingForIsoscelesTriangle(firstPoint, secondPoint, thirdPoint))
            {
                return new IsoscelesTriangle(firstPoint, secondPoint, thirdPoint, Colors.Blue);
            }
            else
            {
                return Successor.Build(firstPoint, secondPoint, thirdPoint);
            }
        }
    }
}
