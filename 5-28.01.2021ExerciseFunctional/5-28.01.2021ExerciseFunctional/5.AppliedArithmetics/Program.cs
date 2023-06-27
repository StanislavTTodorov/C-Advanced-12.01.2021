using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arithmetics = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                Func<string, List<int>, List<int>> func = (input, arithmetics) =>
                {
                    List<int> lists = new List<int>();
                    switch (input)
                    {
                        case "add": return lists = arithmetics.Select(n => n + 1).ToList();
                        case "multiply": return lists = arithmetics.Select(n => n * 2).ToList();
                        case "subtract": return lists = arithmetics.Select(n => n - 1).ToList();
                        default: return lists = arithmetics;
                    }
                };
                arithmetics = func(input, arithmetics);
                if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", arithmetics));
                }
                input = Console.ReadLine();
            }
        }
    }
}