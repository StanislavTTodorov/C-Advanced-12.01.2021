using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> bombTypes = new Dictionary<int, int>()
            {
                {40,0 },
                {60,0 },
                {120,0 }
            };

            Queue<int>  bombsEffects = CreateQueue();
            Stack<int> bombCasings = CreateStack();
          


            while (bombCasings.Count>0&&bombsEffects.Count>0&&(bombTypes[40] < 3 || bombTypes[60] <3 || bombTypes[120] <3))
            {
                int sum = bombCasings.Peek() + bombsEffects.Peek();
                switch (sum)
                {
                    case 40:
                        bombTypes[40] += 1;
                        bombsEffects.Dequeue();
                        bombCasings.Pop();
                        break;
                    case 60:
                        bombTypes[60] += 1;
                        bombsEffects.Dequeue();
                        bombCasings.Pop();
                        break;

                    case 120:
                        bombTypes[120] += 1;
                        bombsEffects.Dequeue();
                        bombCasings.Pop();
                        break;

                    default:
                        int number = bombCasings.Pop()-5;
                        if (number>0)
                        {
                            bombCasings.Push(number);
                        }
                       
                        break;
                }
            }
            if (bombTypes[40] >= 3 && bombTypes[60] >= 3 && bombTypes[120] >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombsEffects.Count>0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",bombsEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (bombCasings.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            Console.WriteLine($"Cherry Bombs: {bombTypes[60]}");
            Console.WriteLine($"Datura Bombs: {bombTypes[40]}");
            Console.WriteLine($"Smoke Decoy Bombs: {bombTypes[120]}");
        }

        private static Queue<int> CreateQueue()
        {
            Queue<int> newQueue = new Queue<int>();
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var number in numbers)
            {
                newQueue.Enqueue(number);
            }
            return newQueue;
        }

        private static Stack<int> CreateStack()
        {
            Stack<int> newStack = new Stack<int>(); 
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var number in numbers)
            {
                newStack.Push(number);
            }
            return newStack;
        }
    }
}
