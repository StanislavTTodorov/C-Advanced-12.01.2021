using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCups = Console.ReadLine();
            string inputBottles = Console.ReadLine();
            Queue<int> cups = new Queue<int>();
            Stack<int> bottles = new Stack<int>();
            foreach (var item in inputCups.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse))
            {
                cups.Enqueue(item);
            }
            foreach (var item in inputBottles.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse))
            {
                bottles.Push(item);
            }
            int water = 0;
            while (cups.Count>0&&bottles.Count>0)
            {
                if (cups.Peek()<=bottles.Peek())
                {
                    water += bottles.Pop() - cups.Dequeue();
                }
                else
                {
                    int cupCopy = cups.Dequeue();
                    while (cupCopy>0)
                    {
                        cupCopy -= bottles.Pop();
                    }
                    water += Math.Abs(cupCopy);
                }               
            }           
            if (cups.Count>0)
            {
                Console.WriteLine($"Cups: {string.Join(" ",cups)}");
            }
            if (bottles.Count>0&&cups.Count==0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {water}");
        }
    }
}
