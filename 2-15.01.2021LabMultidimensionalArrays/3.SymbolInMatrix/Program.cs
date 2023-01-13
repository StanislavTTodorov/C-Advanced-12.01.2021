using System;
using System.Collections.Generic;

namespace _3.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputMatrixData = int.Parse(Console.ReadLine());
            string[,] matrix = new string[inputMatrixData, inputMatrixData];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colSymbols = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colSymbols[col].ToString();
                }
            }
            Queue<string> machSymbolInMatrix = new Queue<string>();
            string searchSymbol = Console.ReadLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (searchSymbol == matrix[row, col])
                    {
                       machSymbolInMatrix.Enqueue($"({row}, {col})");
                    }
                }
            }
            if (machSymbolInMatrix.Count==0)
            {
                Console.WriteLine($"{searchSymbol} does not occur in the matrix");
            }
            else
            {
                Console.WriteLine(machSymbolInMatrix.Dequeue());
            }
        }
    }
}
