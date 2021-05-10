using System;

namespace Task_4_Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EquilateralTriangleBuilder equilateralTriangleBuilder = new EquilateralTriangleBuilder();
                RightTriangleBuilder rightTriangleBuilder = new RightTriangleBuilder();
                IsoscelesTriangleBuilder isoscelesTriangleBuilder = new IsoscelesTriangleBuilder();
                ScaleneTriangleBuilder scaleTriangleBuilder = new ScaleneTriangleBuilder();

                equilateralTriangleBuilder.Successor = rightTriangleBuilder;
                rightTriangleBuilder.Successor = isoscelesTriangleBuilder;
                isoscelesTriangleBuilder.Successor = scaleTriangleBuilder;

                AbstractTriangle triangle = equilateralTriangleBuilder.Build(new Point(0, 5), new Point(0, 0), new Point(5, 0));
                Console.WriteLine(triangle.Color);
                Console.WriteLine(triangle.CalculateAreaOfTriangle());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
