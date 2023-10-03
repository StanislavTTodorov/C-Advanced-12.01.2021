using System;
using System.Collections.Generic;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> position = new List<int>() { 0, 0, 0 };

            position[2] = int.Parse(Console.ReadLine());

            string[][] matrix = Create(position);

            bool successfullySavedPrincess = false;

            while (position[2] >= 0&&!successfullySavedPrincess)
            {
                string[] commands = Console.ReadLine().Split(" ");
                string command = commands[0];
                matrix[int.Parse(commands[1])][ int.Parse(commands[2])] = "B";
                switch (command.ToUpper())
                {
                    case "W":
                        successfullySavedPrincess =  Move(position, matrix, -1, 0);
                        break;
                    case "S":
                        successfullySavedPrincess = Move(position, matrix, 1, 0);
                        break;
                    case "A":
                        successfullySavedPrincess = Move(position, matrix, 0, -1);
                        break;
                    case "D":
                        successfullySavedPrincess = Move(position, matrix, 0, 1);
                        break;
                    default:
                        break;
                }
            }
            //if (!successfullySavedPrincess&&position[2]<0)
            //{
            //    Console.WriteLine($"Mario died at {position[3]};{position[4]}.");
            //}
            if (successfullySavedPrincess)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {position[2]}");
            }
            else 
            {
                Console.WriteLine($"Mario died at {position[3]};{position[4]}.");

            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static bool Move(List<int> position, string[][] matrix, int moveRow, int moveCol)
        {
            int row = position[0] + moveRow;
            int col = position[1] + moveCol;
            position[2] -= 1;
            if (isIn(row,col,matrix))
            {                
                if (matrix[row][col]=="B")
                {
                    position[2] -= 2;
                    if (position[2]>0)
                    {
                        matrix[row][ col] = "-";
                    }
                    else
                    {
                        matrix[row][ col] = "X";
                        position.Add(row);
                        position.Add(col);
                    }                   
                }

                if (matrix[row][ col] == "P")
                {
                    matrix[row][ col] = "-";
                    position[0] = row;
                    position[1] = col;
                    return true;
                }
               
                position[0] = row;
                position[1] = col;               
            }
            else
            {
                if (position[2]<=0&&isIn(row,col,matrix))
                {
                    matrix[row][ col] = "X";
                    position.Add(row);
                    position.Add(col);
                }
                else if(position[2] <= 0)
                {
                    matrix[position[0]][ position[1]] = "X";
                    position.Add(position[0]);
                    position.Add(position[1]);
                }
               
            }
            return false;

        }

        private static string[][] Create(List<int> position)
        {
            int n = int.Parse(Console.ReadLine());

            string[][] matrix = new string[n][];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                string colInput = Console.ReadLine();
                matrix[row] = new string[colInput.Length];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = colInput[col].ToString();
                    if (colInput[col] == 'M')
                    {                      
                        position[0] = row;
                        position[1] = col;
                        matrix[position[0]][position[1]] = "-";
                    }
                    //if (colInput[col] == 'B')
                    //{
                    //    position.Add(row);
                    //    position.Add(col);
                    //}
                }
            }
            return matrix;
        }

        private static bool isIn(int row, int col, string[][] matrix)
        {
            bool on = row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length;
            return on;
        }

      
    }
}
