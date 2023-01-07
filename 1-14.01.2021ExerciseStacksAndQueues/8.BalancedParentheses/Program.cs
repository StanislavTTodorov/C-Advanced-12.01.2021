using System;
using System.Collections.Generic;

namespace _8.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> balanced = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (balanced.Count == 0)
                {
                    balanced.Push(input[i]);
                }
                else if (balanced.Peek() == '{' && input[i] == '}')
                {
                    balanced.Pop();
                }
                else if (balanced.Peek() == '[' && input[i] == ']')
                {
                    balanced.Pop();
                }
                else if (balanced.Peek() == '(' && input[i] == ')')
                {
                    balanced.Pop();
                }
                else if (balanced.Count != 0)
                {
                    balanced.Push(input[i]);
                }
            }
            if (balanced.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

        }
    }
}
