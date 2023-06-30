using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp 
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();

            string second = Console.ReadLine();
            Console.WriteLine(DateModifier.GetDiffBetweenDatesInDays(first, second));

        }
    }
}
