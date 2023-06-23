using System;
using System.Linq;

namespace _4.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] number = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(decimal.Parse)
                    .Select(n => n * 1.2m)
                    .ToArray();
            foreach (var item in number)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
