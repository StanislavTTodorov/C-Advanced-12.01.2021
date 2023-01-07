using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(numbers[0]);
            int s = int.Parse(numbers[1]);
            int x = int.Parse(numbers[2]);
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); ;
            Queue<int> stackOperations = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                stackOperations.Enqueue(int.Parse(input[i]));
            }
            for (int i = 0; i < s; i++)
            {
                stackOperations.Dequeue();
            }
            if (stackOperations.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stackOperations.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {              
                int min = stackOperations.Min(); //int.MaxValue;
               /* for (int i = stackOperations.Count; i > 0; i--)
                {
                    if (min > stackOperations.Peek())
                    {
                        min = stackOperations.Dequeue();
                    }
                    else
                    {
                        stackOperations.Dequeue();
                    }
                }*/
                Console.WriteLine(min);
            }
        }
    }
}
