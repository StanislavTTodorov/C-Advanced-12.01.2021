﻿using System;

namespace _6.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixData = int.Parse(Console.ReadLine());
            long[][] pascal = new long[matrixData][];

            for (int row = 0; row < matrixData; row++)
            {
                pascal[row] = new long[row + 1];
                for (int col = 0; col < row+1; col++)
                {
                    long sum = 0;
                    if (row-1>=0&&col<pascal[row-1].Length)
                    {
                        sum += pascal[row - 1][col];
                    }
                    if (row-1>=0&&col-1>=0)
                    {
                        sum += pascal[row - 1][col - 1];
                    }
                    if (sum==0)
                    {
                        sum = 1;
                    }
                    pascal[row][col] = sum;
                }
            }
            for (int row = 0; row < pascal.Length; row++)
            {
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    Console.Write($"{pascal[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
