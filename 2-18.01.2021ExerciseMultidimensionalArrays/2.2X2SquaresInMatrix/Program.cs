using System;
using System.Linq;

namespace _2._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputMatrixData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[inputMatrixData[0], inputMatrixData[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int indexOfEqual = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    string charMatrix = matrix[row, col];
                    int cout = 0;
                    for (int squaresRow = row; squaresRow < row + 2; squaresRow++)
                    {
                        for (int squaresCol = col; squaresCol < col + 2; squaresCol++)
                        {                         
                            string d = matrix[squaresRow, squaresCol];
                            if (charMatrix == matrix[squaresRow, squaresCol])
                            {
                                cout++;
                            }                         
                        }
                    }
                    if (cout == 4)
                    {
                        indexOfEqual++;
                    }
                }
            }
            Console.WriteLine(indexOfEqual);
        }
    }
}
