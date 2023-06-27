using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] dividersNummbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> list = Enumerable.Range(1, number).ToList();
            List<int> outputList = list.Where(n => IsDivider(dividersNummbers, list, n)).ToList();
            Console.WriteLine(string.Join(" ",outputList));
        }

        private static bool IsDivider(int[] dividersNummbers, List<int> list, int n)
        {
            bool isDivider = true;
            for (int j = 0; j < dividersNummbers.Length; j++)
            {
                if (n % dividersNummbers[j] != 0)
                {
                    isDivider = false;
                    break;
                }
            }
            return isDivider;
        }
    }
}
