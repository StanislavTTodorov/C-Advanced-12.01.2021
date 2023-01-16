using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputMatrixData = int.Parse(Console.ReadLine());
            int[,] matrix = new int[inputMatrixData, inputMatrixData];

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElement = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElement[col];
                    if (row == col)
                    {
                        sumPrimaryDiagonal += colElement[col];
                    }
                    if (row + col == inputMatrixData - 1)
                    {
                        sumSecondaryDiagonal += colElement[col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
        }
    }
}