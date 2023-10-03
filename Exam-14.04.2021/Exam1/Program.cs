using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hatsStack = CreateStack();
            Queue<int> scarfsQueue = CreateQueue();

            List<int> set = new List<int>();

            while (hatsStack.Count>0&&scarfsQueue.Count>0)
            {
                int hat = hatsStack.Peek();
                int scar = scarfsQueue.Peek();
                if (hat == scar)
                {
                    scarfsQueue.Dequeue();
                    hatsStack.Pop();
                    hatsStack.Push(hat + 1);
                }
                else if (hat < scar)
                {
                    hatsStack.Pop();
                }
                else if (hat > scar)
                {
                    int sum = hat + scar;
                    set.Add(sum);
                    scarfsQueue.Dequeue();
                    hatsStack.Pop();
                }
            }
            Console.WriteLine($"The most expensive set is: {set.Max()}");
            Console.WriteLine(string.Join(" ",set));

        }
        private static Queue<int> CreateQueue()
        {
            Queue<int> newQueue = new Queue<int>();
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var number in numbers)
            {
                newQueue.Enqueue(number);
            }
            return newQueue;
        }

        private static Stack<int> CreateStack()
        {
            Stack<int> newStack = new Stack<int>();
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var number in numbers)
            {
                newStack.Push(number);
            }
            return newStack;
        }
    }
}
