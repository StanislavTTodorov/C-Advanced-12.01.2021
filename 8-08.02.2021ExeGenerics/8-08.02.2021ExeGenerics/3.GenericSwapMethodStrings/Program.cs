using System;
using System.Linq;

namespace _3.GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineOfRead = int.Parse(Console.ReadLine());
            Box<int> boxs = new Box<int>();
            for (int i = 0; i < lineOfRead; i++)
            {
                int input = int.Parse(Console.ReadLine());
                boxs.Add(input);
            }
            int[] swapNumbers = Console.ReadLine()
                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                       .ToArray();
            boxs.Swaps(swapNumbers[0], swapNumbers[1]);
            boxs.Print();
        }
    }
}
