using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> countSymbols = new Dictionary<char, int>();
            string inputData = Console.ReadLine();
            for (int i = 0; i < inputData.Length; i++)
            {
                if (countSymbols.ContainsKey(inputData[i]))
                {
                    countSymbols[inputData[i]] += 1;
                }
                else
                {
                    countSymbols.Add(inputData[i], 1);   
                }
            }
            foreach (var item in countSymbols.OrderBy(n=>n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
