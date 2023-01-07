using System;
using System.Collections.Generic;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<int> numbers = new Queue<int>();
            foreach (var item in input.Split(" ", StringSplitOptions.RemoveEmptyEntries))
            {
                if (int.Parse(item)%2==0)
                {
                    numbers.Enqueue(int.Parse(item));
                }               
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
