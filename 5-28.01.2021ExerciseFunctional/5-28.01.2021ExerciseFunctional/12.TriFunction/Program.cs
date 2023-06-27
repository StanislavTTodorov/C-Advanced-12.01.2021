using System;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < list.Length; i++)
            {
               string text = GetFunc(list[i],number);
                if (text.Length>=1)
                {
                    Console.WriteLine(text);
                    break;
                }
            }
        }

        private static string  GetFunc(string word, int number)
        {
             int n = word.ToCharArray().Sum(n => (int)n);
            string text = (n >= number) ? word : string.Empty;
            return text;
        }
                     
    }
}
