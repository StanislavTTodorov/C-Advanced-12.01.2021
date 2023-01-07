using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineOfInputContains = int.Parse(Console.ReadLine());
            Stack<int> element = new Stack<int>();
            for (int i = 0; i < lineOfInputContains; i++)
            {
                int[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                switch (commands[0])
                {
                    case 1:
                        element.Push(commands[1]);
                        break;
                    case 2:
                        if (element.Count>0)
                        {
                            element.Pop();
                        }                       
                        break;
                    case 3:
                        if (element.Count>0)
                        {
                            Console.WriteLine(element.Max());
                        }
                        break;
                    case 4:
                        if (element.Count > 0)
                        {
                            Console.WriteLine(element.Min());
                        }
                        break;

                    default:
                        break;
                }                
            }
            Console.WriteLine(string.Join(", ", element));
        }
    }
}
