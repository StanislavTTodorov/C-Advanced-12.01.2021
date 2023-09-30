using System;
using System.Collections.Generic;
using System.Linq;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int dollars = 50;
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            List<int> position = new List<int>() { 0, 0 , 0};
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colElement = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElement[col].ToString();
                    if (colElement[col] == 'S')
                    {
                        position[0] = row;
                        position[1] = col;
                    }
                    if (colElement[col] == 'O')
                    {
                        position.Add(row);
                        position.Add(col);
                    }
                }
            }
            while (checkPosition(position, matrix)&&position[2]<dollars)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        Move(position,matrix, -1, 0);
                        break;
                    case "right":
                        Move(position, matrix, 0, 1);
                        break;
                    case "down":
                        Move(position, matrix, 1, 0);
                        break;
                    case "left":
                        Move(position, matrix, 0, -1);
                        break;
                    default:
                        break;
                }
            }
            if (position[2] >= dollars)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            else
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            Console.WriteLine($"Money: {position[2]}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }

        }

        private static void Move(List<int> position, string[,] matrix, int moveRow, int moveCol)
        {
            matrix[position[0], position[1]] = "-";
            position[0] += moveRow;
            position[1] += moveCol;
            if (checkPosition(position,matrix))
            {
                string item = matrix[position[0], position[1]];
                if (item == "-")
                {
                    matrix[position[0], position[1]] = "S";
                }
                else if (item == "O")
                {
                    matrix[position[0], position[1]] = "S";
                    if (position.Count >= 4 && position[0] == position[3] && position[1] == position[4])
                    {
                        if (position.Count >= 6)
                        {
                            matrix[position[0], position[1]] = "-";
                            position[0] = position[5];
                            position[1] = position[6];
                        }
                    }
                    else
                    {
                        if (position.Count >= 6)
                        {
                            matrix[position[0], position[1]] = "-";
                            position[0] = position[3];
                            position[1] = position[4];
                            matrix[position[0], position[1]] = "S";
                        }
                    }
                }
                else
                {
                    int coint = int.Parse(matrix[position[0], position[1]]);
                    position[2] += coint;
                    matrix[position[0], position[1]] = "S";
                }
            }
        }

        private static bool checkPosition(List<int> position, string[,] matrix)
        {
            int row = position[0];
            int col = position[1];
            bool onOff = matrix.GetLength(0) > row && row >= 0 && matrix.GetLength(1) > col && col >= 0;
            return onOff;
        }
    }
}
