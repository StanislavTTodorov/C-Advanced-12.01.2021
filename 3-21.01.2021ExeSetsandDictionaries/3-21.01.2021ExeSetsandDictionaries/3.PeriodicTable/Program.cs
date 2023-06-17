using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfData = int.Parse(Console.ReadLine());
            HashSet<string> periodicTable = new HashSet<string>();
            for (int i = 0; i < linesOfData; i++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < elements.Length; j++)
                {
                    periodicTable.Add(elements[j]);
                }
            }
            Console.WriteLine(string.Join(" ", periodicTable.OrderBy(n => n)));          
        }
    }
}
