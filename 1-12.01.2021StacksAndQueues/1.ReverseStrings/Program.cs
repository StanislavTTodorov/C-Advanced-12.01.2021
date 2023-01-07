using System;
using System.Collections.Generic;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverseString = new Stack<char>();
            foreach (var item in input)
            {
                reverseString.Push(item);
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(reverseString.Pop());
            }
        }

    }
}
