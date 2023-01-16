using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[numberOfMatrix, numberOfMatrix];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colElements = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int numberOfKnightsThatNeedsToBeRemoved = 0;
            while (true)
            {
                int count = 0;
                Queue<int> coordinates = new Queue<int>();
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int index = 0;
                        if (matrix[row, col] == 'K')
                        {
                            if (row - 2 >= 0) //up
                            {
                                if (col - 1 >= 0 && 'K' == matrix[row - 2, col - 1])
                                {
                                    index++;
                                }
                                if (col + 1 < matrix.GetLength(1) && 'K' == matrix[row - 2, col + 1])
                                {
                                    index++;
                                }
                            }
                            if (col + 2 < matrix.GetLength(1)) //right
                            {
                                if (row - 1 >= 0 && 'K' == matrix[row - 1, col + 2])
                                {
                                    index++;
                                }
                                if (row + 1 < matrix.GetLength(0) && 'K' == matrix[row + 1, col + 2])
                                {
                                    index++;
                                }
                            }
                            if (row + 2 < matrix.GetLength(0)) //down
                            {
                                if (col - 1 >= 0 && 'K' == matrix[row + 2, col - 1])
                                {
                                    index++;
                                }
                                if (col + 1 < matrix.GetLength(1) && 'K' == matrix[row + 2, col + 1])
                                {
                                    index++;
                                }
                            }
                            if (col - 2 >= 0)//left
                            {
                                if (row - 1 >= 0 && 'K' == matrix[row - 1, col - 2])
                                {
                                    index++;
                                }
                                if (row + 1 < matrix.GetLength(0) && 'K' == matrix[row + 1, col - 2])
                                {
                                    index++;
                                }
                            }
                        }
                        if (index > count)
                        {
                            coordinates = new Queue<int>();
                            count = index;
                            coordinates.Enqueue(row);
                            coordinates.Enqueue(col);
                        }
                    }
                }
                if (coordinates.Count > 0)
                {
                    matrix[coordinates.Dequeue(), coordinates.Dequeue()] = 'O';
                    numberOfKnightsThatNeedsToBeRemoved++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(numberOfKnightsThatNeedsToBeRemoved);
        }
    }
}