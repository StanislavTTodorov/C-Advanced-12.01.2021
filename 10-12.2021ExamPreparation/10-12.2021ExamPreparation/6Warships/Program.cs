using System;
using System.Collections.Generic;
using System.Linq;

namespace _6Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> attackCommands = new Queue<string>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries));
            string[,] matrix = new string[n, n];
            List<int> playerOne = new List<int>() { 0 };
            List<int> playerTwo = new List<int>() { 0 };
            List<int> shipsDestroye = new List<int>() { 0 };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElemens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElemens[col];
                    if (colElemens[col] == "<")
                    {
                        playerOne[0]++;
                    }
                    if (colElemens[col] == ">")
                    {
                        playerTwo[0]++;
                    }
                }
            }

            while (attackCommands.Count > 0 && playerOne[0] != 0 && playerTwo[0] != 0)
            {
                string commands = attackCommands.Dequeue();
                string[] attack = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(attack[0]);
                int col = int.Parse(attack[1]);
                if (isOut(row, col, n))
                {
                    string symbol = matrix[row, col];

                    if (symbol == "<")
                    {
                        playerOne[0]--;
                        shipsDestroye[0]++;
                        matrix[row, col] = "X";
                    }
                    if (symbol == ">")
                    {
                        playerTwo[0]--;
                        shipsDestroye[0]++;
                        matrix[row, col] = "X";
                    }
                    if (symbol == "#")
                    {
                        List<int> position = new List<int>() { row, col };
                        matrix[row, col] = "X";
                        Move(position, matrix, n, -1, 0, playerOne, playerTwo, shipsDestroye);
                        Move(position, matrix, n, -1, +1, playerOne, playerTwo, shipsDestroye);

                        Move(position, matrix, n, 0, 1, playerOne, playerTwo, shipsDestroye);
                        Move(position, matrix, n, -1, 1, playerOne, playerTwo, shipsDestroye);

                        Move(position, matrix, n, 1, 0, playerOne, playerTwo, shipsDestroye);
                        Move(position, matrix, n, 1, 1, playerOne, playerTwo, shipsDestroye);

                        Move(position, matrix, n, 0, -1, playerOne, playerTwo, shipsDestroye);
                        Move(position, matrix, n, -1, -1, playerOne, playerTwo, shipsDestroye);
                    }
                }
            }
            if (playerOne[0]>0&&playerTwo[0]==0)
            {
                Console.WriteLine($"Player One has won the game! {shipsDestroye[0]} ships have been sunk in the battle.");
            }
            else if (playerTwo[0]>0&&playerOne[0]==0)
            {
                Console.WriteLine($"Player Two has won the game! {shipsDestroye[0]} ships have been sunk in the battle.");
            }
           else 
            {
                Console.WriteLine($"It's a draw! Player One has {playerOne[0]} ships left. Player Two has {playerTwo[0]} ships left.");
            }
        }

        private static void Move(List<int> position, string[,] matrix, int n, int row, int col, List<int> playerOne, List<int> playerTwo, List<int> shipsDestroye)
        {
            List<int> newPosition = new List<int>(position);
            if (isOut(newPosition[0], newPosition[1], matrix.GetLength(0)))
            {
                newPosition[0] += row;
                newPosition[1] += col;
                if (isOut(newPosition[0], newPosition[1], matrix.GetLength(0)))
                {
                    string symbol = matrix[newPosition[0], newPosition[1]];
                    if (symbol == "<")
                    {
                        playerOne[0]--;
                        shipsDestroye[0]++;
                    }
                    if (symbol == ">")
                    {
                        playerTwo[0]--;
                        shipsDestroye[0]++;
                    }
                    matrix[newPosition[0], newPosition[1]] = "X";
                }
            }
        }

        private static bool isOut(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
