using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3_Matrix
{
    class SquareMatrix
    {
        protected int[] matrix;
        public int Size { get; }

        public SquareMatrix(int size)
        {
            Size = size;
            matrix = new int[Size * Size];
            RandomSquareMatrixInitialization();
        }

        public void RandomSquareMatrixInitialization()
        {
            Random random = new Random();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrix[i * Size + j] = random.Next(10);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    str.Append(matrix[i * Size + j]);
                    str.Append(" ");
                }
                str.Append("\n");
            }

            return str.ToString();
        }
    }
}
