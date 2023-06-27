using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersStartEnd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Func<int, bool> condition = GetCommand(command);
            Func<int[], Func<int, bool>, List<int>> generateNumbers = (number, condition) =>
            {
                List<int> numbers = new List<int>();
                int start = numbersStartEnd[0];
                int end = numbersStartEnd[1];
                for (int i = start; i <= end; i++)
                {
                    if (condition(i))
                    {
                        numbers.Add(i);
                    }
                }
                return numbers;
            };
            List<int> numbers = generateNumbers(numbersStartEnd,condition);
           // List<int> list = Enumerable.Range(numbersStartEnd[0], numbersStartEnd[1]).ToList();
            Console.WriteLine(string.Join(" ",numbers));
            //Console.WriteLine(string.Join(" ",  list));
        }
        private static Func<int, bool> GetCommand(string command)
        {
            switch (command)
            {
                case "odd":return n => n % 2 != 0 ;
                case "even": return n => n % 2 == 0;
                default:
                    return null;
            }
        }
    }
}
