using System;
using System.Linq;

namespace _3.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> minNumber =
              n =>
             {
                 int min = int.MaxValue;
                 foreach (var item in n)
                 {
                     if (item < min)
                     {
                         min = item;
                     }
                 }
                 return min;
             };
            Console.WriteLine(minNumber(numbers));
        }
    }
}
