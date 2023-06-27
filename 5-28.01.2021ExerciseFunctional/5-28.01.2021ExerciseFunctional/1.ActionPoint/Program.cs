using System;

namespace _1.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join(Environment.NewLine,names));
            Func<string, string> action = name => $"{name}";
            foreach (var item in names)
            {
                Console.WriteLine(action(item));
            }
        }

      
    } 
}
