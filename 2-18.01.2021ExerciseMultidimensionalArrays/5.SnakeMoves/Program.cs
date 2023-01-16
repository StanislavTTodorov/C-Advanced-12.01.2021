using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputmatrixData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string snake = Console.ReadLine();
            char[,] matrix = new char[inputmatrixData[0], inputmatrixData[1]];         
            Queue<char> queueSnake = new Queue<char>();
            int capacity = inputmatrixData[0] * inputmatrixData[1];
            int counter = 0;
            for (int i = 0; i < snake.Length; i++)
            {
                counter++;
                queueSnake.Enqueue(snake[i]);
                if (capacity==counter)
                {
                    break;
                }
                if (snake.Length-1 ==i)
                {
                    i = -1;
                }
            }
            for (int row = 1; row <= matrix.GetLength(0); row++)
            {
                if (row%2==0)
                {
                    for (int col  = matrix.GetLength(1) - 1; col  >= 0; col --)
                    {
                        matrix[row - 1, col] = queueSnake.Dequeue();                       
                    }
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row - 1, col] = queueSnake.Dequeue();
                        
                    }  
                }                
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
