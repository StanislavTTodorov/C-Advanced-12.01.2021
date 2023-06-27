using System;
using System.Linq;

namespace _2.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(name=>$"Sir {name}")
                .ToArray();
            //Func<string, string> print = name => $"Sir {name}";
            //foreach (var name in names)
            //{
            //    Console.WriteLine(print(name));
            //}
            //Console.WriteLine(string.Join(Environment.NewLine,names));
            Action<string[]> printName = n => Console.WriteLine(string.Join(Environment.NewLine, n));
            printName(names);
        }
    }
}
