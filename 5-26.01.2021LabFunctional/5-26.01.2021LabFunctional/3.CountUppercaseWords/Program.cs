using System;
using System.Linq;

namespace _3.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => char.IsUpper(n[0]))             
                .ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,words));
            
        }

        
        
    }
}
