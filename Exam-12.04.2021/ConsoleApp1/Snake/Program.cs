using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> position = new List<int>() { 0, 0, 0 };
            int food = 10;
            string[,] matrix = Create(position);

            string command = Console.ReadLine();
            while (isInMatrix(position, command, matrix) && position[2] < food)
            {
                command = Console.ReadLine();
            }
            if (position[2]>=food)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            else
            {
                Console.WriteLine("Game over!");
            }
            Console.WriteLine($"Food eaten: {position[2]}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }

        }

        private static bool isInMatrix(List<int> position, string command, string[,] matrix)
        {
            switch (command)
            {
                case "up":
                    return Move(position, matrix, -1, 0);
                case "down":
                    return Move(position, matrix, 1, 0);
                case "left":
                    return Move(position, matrix, 0, -1);
                case "right":
                    return Move(position, matrix, 0, 1);
                default:
                    return false;                 
            }
        }

        private static bool Move(List<int> position, string[,] matrix, int moveRow, int moveCol)
        {
            int row = position[0] + moveRow;
            int col = position[1] + moveCol;
            if (isIn(row, col, matrix))
            {
                matrix[position[0], position[1]] = ".";
                if (matrix[row, col] == "*")
                {
                    position[2] += 1;
                }
                if (matrix[row, col] == "B")
                {
                    if (row == position[3] && col == position[4])
                    {
                        matrix[row, col] = ".";
                        row = position[5];
                        col = position[6];
                    }
                    else if (row == position[5] && col == position[6])
                    {
                        matrix[row, col] = ".";
                        row = position[3];
                        col = position[4];
                    }
                }
                position[0] = row;
                position[1] = col;
                matrix[position[0], position[1]] = "S";


                return true;
            }
            matrix[position[0], position[1]] = ".";
            return false;
        }

        private static bool isIn(int row, int col, string[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static string[,] Create(List<int> position)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colInput = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colInput[col].ToString();
                    if (colInput[col] == 'S')
                    {
                        position[0] = row;
                        position[1] = col;
                    }
                    if (colInput[col] == 'B')
                    {
                        position.Add(row);
                        position.Add(col);
                    }
                }
            }
            return matrix;
        }
    }
}
