using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountSameValuesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> countValues = new Dictionary<double, int>();
            double[] inputData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < inputData.Length; i++)
            {
                if (countValues.ContainsKey(inputData[i]))
                {
                    countValues[inputData[i]]++;
                }
                else
                {
                    countValues.Add(inputData[i], 1);
                }
            }
            foreach (var item in countValues)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
