using System;
using System.Collections.Generic;
using System.Linq;

namespace _1Flower
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>();           
            int[] inputLilies = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (var item in inputLilies)
            {
                lilies.Push(item);
            }
            Queue<int> roses = new Queue<int>();
            int[] inputRoses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (var item in inputRoses)
            {
                roses.Enqueue(item);
            }

            int storeFlower = 0;
            int countFlower = 0;
            while (lilies.Count>0&&roses.Count>0)
            {
                int liliesTem = lilies.Peek();
                while (liliesTem+roses.Peek()>15)
                {
                    liliesTem -= 2;
                }
                if (liliesTem+roses.Peek()==15)
                {
                    countFlower++;
                    roses.Dequeue();
                    lilies.Pop();
                }
                else
                {
                    storeFlower += liliesTem + roses.Peek();
                    roses.Dequeue();
                    lilies.Pop();
                }
            }
            countFlower += storeFlower / 15;
            string text = (countFlower >= 5) ? $"You made it, you are going to the competition with {countFlower} wreaths!" :
                                               $"You didn't make it, you need {5 - countFlower} wreaths more!";
            Console.WriteLine(text);
        }
    }
}
