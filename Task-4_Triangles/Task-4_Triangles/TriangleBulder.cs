using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    abstract class TriangleBulder
    {
        public TriangleBulder Successor { get; set; }

        public abstract AbstractTriangle Build(Point firstPoint, Point secondPoint, Point thirdPoint);
    }
}