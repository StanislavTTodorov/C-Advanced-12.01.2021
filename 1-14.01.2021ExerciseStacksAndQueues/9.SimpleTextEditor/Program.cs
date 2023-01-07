using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOperations = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            Stack<string> undoes = new Stack<string>();
            undoes.Push(builder.ToString());
            for (int i = 0; i < numberOperations; i++)
            {
                string[] inputCommands = Console.ReadLine().Split();
                switch (inputCommands[0])
                {
                    case "1":
                        builder.Append(inputCommands[1]);
                        undoes.Push(builder.ToString());
                        break;
                    case "2":
                        int count = int.Parse(inputCommands[1]);
                        builder.Remove(builder.Length - count, count);                       
                        undoes.Push(builder.ToString());
                        break;
                    case "3":                       
                            Console.WriteLine(builder[(int.Parse(inputCommands[1])) - 1]);                       
                        break;
                    case "4":
                        undoes.Pop();
                        builder = new StringBuilder();
                        builder.Append(undoes.Peek());
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}
