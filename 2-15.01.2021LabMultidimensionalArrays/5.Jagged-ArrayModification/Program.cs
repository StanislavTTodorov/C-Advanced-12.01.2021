using System;
using System.Linq;

namespace _5.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[inputMatrix, inputMatrix];
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
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commands = input.Split();
                AddSubtract(matrix, commands);
                input = Console.ReadLine();
            }
            Print(matrix);
        }

        private static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void AddSubtract(int[,] matrix, string[] commands)
        {
            string command = commands[0];
            int addRow = int.Parse(commands[1]);
            int addCol = int.Parse(commands[2]);
            int add = int.Parse(commands[3]);
            if (addRow >= 0 &&
                addRow < matrix.GetLength(0) &&
                addCol >= 0 &&
                addCol < matrix.GetLength(1))
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (row == addRow && col == addCol && command == "Add")
                        {
                            matrix[row, col] += add;
                        }
                        if (row == addRow && col == addCol && command == "Subtract")
                        {
                            matrix[row, col] -= add;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
            }
        }


    }
}
