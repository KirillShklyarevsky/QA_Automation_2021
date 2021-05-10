using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class ScaleneTriangle : AbstractTriangle
    {
        public ScaleneTriangle(Point firstPoint, Point secondPoint, Point thirdPoint, Colors color)
                              : base(firstPoint, secondPoint, thirdPoint, color) { }
    }
}
