using System;
using System.Linq;

namespace _2.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizes, sizes];
            int sum = 0;
            for (int col  = 0; col  < matrix.GetLength(0); col ++)
            {
                int[] rowElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[col, row] = rowElements[row];
                    if (col==row)
                    {
                        sum += rowElements[row];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
