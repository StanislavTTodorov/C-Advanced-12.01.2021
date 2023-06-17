using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> nElement = new HashSet<int>();
            HashSet<int> mElement = new HashSet<int>();
            for (int i = 0; i < input[0]; i++)
            {
                nElement.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < input[1]; i++)
            {
                mElement.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(string.Join(" ",nElement.Intersect(mElement)));

        }
    }
}
