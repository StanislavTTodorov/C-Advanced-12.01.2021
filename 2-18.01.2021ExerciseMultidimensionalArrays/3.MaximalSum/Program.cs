using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] inputMatrixData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[inputMatrixData[0], inputMatrixData[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int max = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - n + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - n + 1; col++)
                {
                    int sum = 0;
                    for (int squaresRow = row; squaresRow < row + n; squaresRow++)
                    {
                        for (int squaresCol = col; squaresCol < col + n; squaresCol++)
                        {
                            sum += matrix[squaresRow, squaresCol];
                        }
                    }
                    if (max < sum)
                    {
                        max = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {max}");
            for (int row = maxRow; row < maxRow + n; row++)
            {
                for (int col = maxCol; col < maxCol + n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
