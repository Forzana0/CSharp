using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Task4
    {
        static void Main()
        {
            int[,] A = { { 1, 2 }, { 3, 4 } };
            int[,] B = { { 5, 6 }, { 7, 8 } };

            int[,] sum = AddMatrices(A, B);
            PrintMatrix(sum);

            int scalar = 2;
            int[,] multiplied = MultiplyMatrixByScalar(A, scalar);
            PrintMatrix(multiplied);

            int[,] product = MultiplyMatrices(A, B);
            PrintMatrix(product);
        }

        static int[,] AddMatrices(int[,] A, int[,] B)
        {
            int rows = A.GetLength(0);
            int cols = A.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = A[i, j] + B[i, j];
            return result;
        }

        static int[,] MultiplyMatrixByScalar(int[,] matrix, int scalar)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = matrix[i, j] * scalar;
            return result;
        }

        static int[,] MultiplyMatrices(int[,] A, int[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int rowsB = B.GetLength(0);
            int colsB = B.GetLength(1);
            if (colsA != rowsB)
                throw new InvalidOperationException("Матриці не можуть бути помножені");

            int[,] result = new int[rowsA, colsB];
            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < colsB; j++)
                    for (int k = 0; k < colsA; k++)
                        result[i, j] += A[i, k] * B[k, j];
            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
