using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputMatrixData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
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
            string inputCommand = Console.ReadLine();
            while (inputCommand != "END")
            {
                string[] commands = inputCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "swap" && commands.Count() == 5)
                {
                    Swap(matrix, commands);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


                inputCommand = Console.ReadLine();
            }
        }

        private static void Print(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static void Swap(string[,] matrix, string[] commands)
        {
            int row1 = int.Parse(commands[1]);
            int col1 = int.Parse(commands[2]);
            int row2 = int.Parse(commands[3]);
            int col2 = int.Parse(commands[4]);
            bool isValidCoordinates = row1 >= 0 && row1 <= matrix.GetLength(0) &&
                                      col1 >= 0 && col1 <= matrix.GetLength(1) &&
                                      row2 >= 0 && row2 <= matrix.GetLength(0) &&
                                      col2 >= 0 && col2 <= matrix.GetLength(1);
            if (isValidCoordinates)
            {
                string copy = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = copy;
                Print(matrix);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
