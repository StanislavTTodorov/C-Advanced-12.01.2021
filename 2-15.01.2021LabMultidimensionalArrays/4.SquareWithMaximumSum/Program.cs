using System;
using System.Linq;

namespace _4.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int[] inputMatrixData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[inputMatrixData[0], inputMatrixData[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int max = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;
            for (int row = 0; row < matrix.GetLength(0)-n+1; row++)
            {
                for (int col = 0; col <  matrix.GetLength(1)-n+1; col++)
                {
                    int squareSum = 0;
                    for (int squareRow  = row; squareRow  < row+n; squareRow ++)
                    {
                        for (int squreCol = col; squreCol < col+n; squreCol++)
                        {
                            squareSum += matrix[squareRow, squreCol];
                        }
                    }
                    if (squareSum>max)
                    {
                        max = squareSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }
            for (int row = maxSumRow; row < maxSumRow+n; row++)
            {
                for (int col = maxSumCol; col < maxSumCol+n; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(max);
        }
        
    }
}
