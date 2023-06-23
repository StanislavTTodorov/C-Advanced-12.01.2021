using System;
using System.Linq;

namespace _2.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSumAndCount(a => a.Length, array => array.Sum());
        }
        static void PrintSumAndCount(Func<int[], int> countGetter,
                                     Func<int[], int> sumCalcularor)
        {
            int[] array = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(countGetter(array));
            Console.WriteLine(sumCalcularor(array));
        }
    }
}
