using System;
using System.Linq;

namespace _7.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(n=>n.Length<=length).ToArray();
            Action<string[]> print = n => Console.WriteLine(string.Join(Environment.NewLine,n));
            print(names);
        }
    }
}
