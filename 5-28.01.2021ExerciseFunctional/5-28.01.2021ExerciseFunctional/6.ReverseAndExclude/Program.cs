using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .Reverse()
                 .ToList();
            int givenNumber = int.Parse(Console.ReadLine());
            Func <List<int>, int, List<int>> func = (numbers, givennumber) =>
              {
                  List<int> list = new List<int>();
                  list = numbers.Where(n => n % givennumber != 0).ToList();
                  return list;
              };
            Action<List<int>> print = list =>Console.WriteLine(string.Join(" ", list));
            print(func(numbers, givenNumber));            
        }    
    }
}
