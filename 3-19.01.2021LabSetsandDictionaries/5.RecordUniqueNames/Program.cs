using System;
using System.Collections.Generic;

namespace _5.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfData = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();
            for (int i = 0; i < linesOfData; i++)
            {
                string name = Console.ReadLine();

                uniqueNames.Add(name);

            }
            foreach (var name in uniqueNames)
            {
                Console.WriteLine("    " + name);
            }
        }
    }
}
