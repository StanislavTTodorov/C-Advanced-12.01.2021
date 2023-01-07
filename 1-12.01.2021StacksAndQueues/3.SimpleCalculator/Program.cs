using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> calculator = new Stack<string>();
            foreach (var item in input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse())
            {
                calculator.Push(item);
            }
            while (calculator.Count > 1)
            {            
                int lastNumber = int.Parse(calculator.Pop());
                string symbol = calculator.Pop();
                int secondNumber = int.Parse(calculator.Pop());
                int result = symbol == "+" ? lastNumber + secondNumber : lastNumber - secondNumber;
                calculator.Push(result.ToString());
            }
            Console.WriteLine(calculator.Pop());
        }
    }
}
