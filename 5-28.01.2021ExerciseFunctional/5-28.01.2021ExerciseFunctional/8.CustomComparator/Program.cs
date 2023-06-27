using System;
using System.Linq;

namespace _8.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            //double[] even = numbers.Where(n => n % 2 == 0).OrderBy(n=>n).ToArray();
            //double[] odd = numbers.Where(n => n % 2 != 0).OrderBy(n=>n).ToArray();
            //if (even.Length > 0 && odd.Length > 0)
            //{
            //    Console.WriteLine($"{string.Join(" ", even)} {string.Join(" ", odd)}");
            //}
            //else if (even.Length > 0 && odd.Length == 0)
            //{
            //    Console.WriteLine(string.Join(" ", even));
            //}
            //else if (even.Length == 0 && odd.Length > 0)
            //{
            //    Console.WriteLine(string.Join(" ", odd));
            //}

            Array.Sort(numbers, (a, b) =>
                (a % 2 == 0 && b % 2 != 0) ? -1 :
                (a % 2 != 0 && b % 2 == 0) ? 1 :
                a.CompareTo(b));
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
