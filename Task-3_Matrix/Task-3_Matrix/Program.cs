using System;

namespace Task_3_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareMatrix squareMatrix = new SquareMatrix(5);
            DiagonalMatrix diagonalMatrix = new DiagonalMatrix(5);
            Console.WriteLine(squareMatrix.ToString());
            Console.WriteLine(diagonalMatrix.ToString());

        }
    }
}
