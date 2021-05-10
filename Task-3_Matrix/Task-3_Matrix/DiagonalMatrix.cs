using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3_Matrix
{
    class DiagonalMatrix : SquareMatrix
    {
        public DiagonalMatrix(int size) : base(size)
        {
            matrix = new int[size];
            RandomMatrixInitialization();
        }

        public void RandomMatrixInitialization()
        {
            Random random = new Random();

            for (int i = 0; i < Size; i++)
            {
                matrix[i] = random.Next(10);
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            int counter = 0;
            for (int i = 0; i < Size; i++)
            {

                for (int j = 0; j < Size; j++)
                {
                    if (i == j)
                    {
                        str.Append(matrix[i] + " ");
                        j++;
                    }

                    
                    str.Append("  ");
                    counter++;
                }

                str.Append("\n");
            }

            return str.ToString();
        }
    }
}
