using System;
using System.Collections.Generic;

namespace _2Bee
{
    class Program
    {
      

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];
            List<int> rowBee=new List<int>();
            List<int>colBee=new List<int>();
            int flowers = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colElemens = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElemens[col].ToString();
                    if (colElemens[col].ToString()=="B")
                    {
                        rowBee.Add(row);
                        colBee.Add(col);
                    }
                }
            }
            string input = Console.ReadLine();
            while (input!="End"&&isBeeOut(rowBee[0],colBee[0],size))
            {
                flowers += SearshFlowers(rowBee, colBee, matrix,input);
                if (!isBeeOut(rowBee[0], colBee[0], size))
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (!isBeeOut(rowBee[0], colBee[0], size))
            {
                Console.WriteLine("The bee got lost!");
            }
            string text = flowers >= 5 ? $"Great job, the bee managed to pollinate {flowers} flowers!" :
                                      $"The bee couldn't pollinate the flowers, she needed {5 - flowers} flowers more";
            Console.WriteLine(text);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static int SearshFlowers(List<int> rowBee, List<int> colBee, string[,] matrix,string input)
        {
            matrix[rowBee[0], colBee[0]] = ".";
            CoordinatesChange(input, rowBee, colBee);
            int flowers = 0;
            if (isBeeOut(rowBee[0],colBee[0],matrix.GetLength(0)))
            {                
                string moveNext = matrix[rowBee[0], colBee[0]];
                if (moveNext == "O")
                {
                    matrix[rowBee[0], colBee[0]] = ".";
                    CoordinatesChange(input, rowBee, colBee);
                }
                if (isBeeOut(rowBee[0], colBee[0], matrix.GetLength(0)))
                {
                    moveNext = matrix[rowBee[0], colBee[0]];
                    if (moveNext == "f")
                    {                     
                        flowers++;
                        matrix[rowBee[0], colBee[0]] = "B";
                    }
                    else
                    {
                        matrix[rowBee[0], colBee[0]] = "B";
                    }
                }
            }
            return flowers;
        }

        private static void CoordinatesChange(string input, List<int> rowBee, List<int> colBee)
        {
            switch (input)
            {
                case "up":
                    rowBee[0] -= 1;
                    break;
                case "right":                    
                    colBee[0] += 1;
                    break;
                case "left":
                    colBee[0] -= 1;
                    break;
                case "down":
                    rowBee[0] += 1;
                    break;
            }
        }

        private static bool isBeeOut(int rowBee, int colBee, int size)
        {
            return rowBee >= 0 && rowBee < size && colBee >= 0 && colBee < size;
        }
    }
}
