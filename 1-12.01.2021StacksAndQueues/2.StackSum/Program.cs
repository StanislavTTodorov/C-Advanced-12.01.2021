using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Stack<int> numbers = new Stack<int>();
            int stackSum = 0;
            foreach (var item in input.Split())
            {
                numbers.Push(int.Parse(item.ToString()));
            }                       
            while (input != "end")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commands.Contains("add"))
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        numbers.Push(int.Parse(commands[i]));
                    }
                }
                else if (commands.Contains("remove"))
                {
                    if (int.Parse(commands[1])<=numbers.Count)
                    {
                        for (int i = 0; i < int.Parse(commands[1]); i++)
                        {
                            numbers.Pop();
                        }
                    }
                   
                }                       
                input = Console.ReadLine().ToLower();
            }
            
            for (int i = numbers.Count; i > 0; i--)
            {
                stackSum += numbers.Pop();
            }
           
            Console.WriteLine($"Sum: {stackSum}");

        }
    }
}
