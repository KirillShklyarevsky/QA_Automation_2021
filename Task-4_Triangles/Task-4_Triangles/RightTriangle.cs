using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class RightTriangle : AbstractTriangle, ICalculateAreaOfTriangle
    {
        private const string _color = "Green";

        public string Color { get; }

        public RightTriangle(Point firstPoint, Point secondPoint, Point thirdPoint) : base(firstPoint, secondPoint, thirdPoint) { }

        private bool CheckingForRightTriangle()
        {
            return FirstSideLength * FirstSideLength + SecondSideLength * SecondSideLength == ThirdSideLength * ThirdSideLength ||
                   FirstSideLength * FirstSideLength + ThirdSideLength * ThirdSideLength == SecondSideLength * SecondSideLength ||
                   ThirdSideLength * ThirdSideLength + SecondSideLength * SecondSideLength == FirstSideLength * FirstSideLength;
        }

        public double CalculateAreaOfTriangle()
        {
            if (FirstSideLength > SecondSideLength && FirstSideLength > ThirdSideLength)
            {
                return SecondSideLength * ThirdSideLength / 2;
            }

            if (SecondSideLength > FirstSideLength && SecondSideLength > ThirdSideLength)
            {
                return FirstSideLength * ThirdSideLength / 2;
            }
            else
            {
                return FirstSideLength * SecondSideLength / 2;
            }
        }
    }
}
