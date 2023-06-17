using System;
using System.Collections.Generic;

namespace _4.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<int,int> evenNumbers = new Dictionary<int,int>();
            for (int i = 0; i < numberOfLines; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (evenNumbers.ContainsKey(number))
                {
                    evenNumbers[number] += 1;
                }
                else
                {
                    evenNumbers.Add(number, 1);
                }
            }
            HashSet<int> print = new HashSet<int>();
            foreach (var item in evenNumbers)
            {
                if (item.Value%2==0)
                {
                    print.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(" ",print));
        }
    }
}
