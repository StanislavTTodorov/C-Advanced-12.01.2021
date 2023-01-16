using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            double[][] jagged = new double[numberOfRows][];

            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                double[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jagged[row] = new double[colElements.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = colElements[col];
                }
            }
            for (int row = 0; row < jagged.GetLength(0) - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    jagged[row] = jagged[row].Select(n => n * 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(n => n * 2).ToArray();
                }
                else
                {
                    jagged[row] = jagged[row].Select(n => n / 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(n => n / 2).ToArray();
                }
            }
            string inputCommands = Console.ReadLine();
            while (inputCommands != "End")
            {
                string[] commands = inputCommands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int row1 = int.Parse(commands[1]);
                int col1 = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                bool isValidCell = row1 >= 0 && row1 < numberOfRows && col1 >= 0 && col1 < jagged[row1].Length;
                if (commands[0] == "Add" && isValidCell)
                {
                    jagged[row1][col1] += value;
                }
                else if (commands[0] == "Subtract" && isValidCell)
                {
                    jagged[row1][col1] -= value;
                }
                inputCommands = Console.ReadLine();
            }
            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
