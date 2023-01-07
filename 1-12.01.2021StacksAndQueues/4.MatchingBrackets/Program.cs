using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    brackets.Push(i);
                }
                if (input[i]==')')
                {
                    int startNumber = brackets.Pop();
                    string text = input.Substring(startNumber, i - startNumber+1);
                    Console.WriteLine(text);
                }
            }

        }
    }
}
