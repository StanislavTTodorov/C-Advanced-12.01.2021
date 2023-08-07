using System;
using System.Collections.Generic;
using System.Linq;

namespace _1Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            int taskToBeKilled = int.Parse(Console.ReadLine());
            while (tasks.Count > 0 && threads.Count > 0)
            {
                if (taskToBeKilled == tasks.Peek())
                {
                    Console.WriteLine($"Thread with value {threads.Peek()} killed task {tasks.Peek()}");
                    break;
                }
                if (threads.Peek() >= tasks.Peek())
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
