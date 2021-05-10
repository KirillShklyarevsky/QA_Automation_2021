using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class ScaleneTriangleBuilder : TriangleBulder
    {
        public override AbstractTriangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new ScaleneTriangle(firstPoint, secondPoint, thirdPoint, Colors.White);
        }
    }
}
