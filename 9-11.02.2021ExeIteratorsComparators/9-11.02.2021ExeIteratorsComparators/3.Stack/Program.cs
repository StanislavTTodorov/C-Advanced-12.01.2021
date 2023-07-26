using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stacks = new MyStack<string>();
            string input = Console.ReadLine();
            while (input!="END")
            {
                
                if (input.Contains("Push"))
                {
                    string[] array = input.Remove(0, 5).Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    stacks.Push(array);
                }
                else if (input.Contains("Pop"))
                {
                    stacks.Pop();
                }
                input = Console.ReadLine();
            }
            Stack<string> stackCopy = new Stack<string>();
            foreach (var item in stacks)
            {
                stackCopy.Push(item);
                Console.WriteLine(item);
            }
            foreach (var item in stackCopy.Reverse())
            {
                Console.WriteLine(item);
            }

        }      
    }
}
