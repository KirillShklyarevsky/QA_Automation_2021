using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_Triangles
{
    class IsoscelesTriangle : AbstractTriangle, ICalculateAreaOfTriangle
    {
        private const string _color = "Blue";

        public string Color { get; }

        public IsoscelesTriangle(Point firstPoint, Point secondPoint, Point thirdPoint) : base(firstPoint, secondPoint, thirdPoint) { }

        private bool CheckingForIsoscelesTriangle()
        {
            return (FirstSideLength == SecondSideLength || FirstSideLength == ThirdSideLength || SecondSideLength == ThirdSideLength);
        }

        public double CalculateAreaOfTriangle()
        {
            if (FirstSideLength == SecondSideLength)
            {
                return (ThirdSideLength / 4 * Math.Sqrt(4 * Math.Pow(FirstSideLength, 2) - Math.Pow(ThirdSideLength, 2)));
            }

            if (FirstSideLength == ThirdSideLength)
            {
                return (SecondSideLength / 4 * Math.Sqrt(4 * Math.Pow(FirstSideLength, 2) - Math.Pow(SecondSideLength, 2)));
            }
            else
            {
                return (FirstSideLength / 4 * Math.Sqrt(4 * Math.Pow(SecondSideLength, 2) - Math.Pow(FirstSideLength, 2)));
            }
        }
    }
}
