using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }
            string input = Console.ReadLine();
            while (input != "Bloom Bloom Plow")
            {
                List<int> position = input.Split(" ").Select(int.Parse).ToList();
                if (isPositionЕxists(position[0], position[1], size))
                {
                    matrix[position[0], position[1]] += 1;

                    Move(position, matrix, size, -1, 0);
                    Move(position, matrix, size, 0, 1);
                    Move(position, matrix, size, 0, -1);
                    Move(position, matrix, size, 1, 0);
                }
                else 
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                input = Console.ReadLine();
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix.GetLength(1) + 1 == col)
                    {
                        Console.Write($"{matrix[row, col]}");
                    }
                    else
                    {
                        Console.Write($"{matrix[row, col]} ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Move(List<int> position, int[,] matrix,int[] size, int row, int col)
        {
            List<int> newPosition = new List<int>(position);
            while (isPositionЕxists(newPosition[0],newPosition[1],size))
            {              
                newPosition[0] += row;
                newPosition[1] += col;
                if (isPositionЕxists(newPosition[0], newPosition[1], size))
                {
                    matrix[newPosition[0], newPosition[1]] += 1;
                }
            }
        }

        private static bool isPositionЕxists(int row,int col, int[] size)
        {
            return row >= 0 && row < size[0] && col >= 0 && col < size[1];
        }      
    }
}
