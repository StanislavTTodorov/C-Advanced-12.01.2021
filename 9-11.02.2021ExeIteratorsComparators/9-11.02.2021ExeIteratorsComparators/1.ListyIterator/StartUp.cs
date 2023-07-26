using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inputList = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            inputList.RemoveAt(0);// Ще стане бавно
            ListyIterator<string> myList = new ListyIterator<string>(inputList);
            input = Console.ReadLine();
            while (input != "END")
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(myList.MoveNext());
                        break;
                    case "HasNext":
                        Console.WriteLine(myList.HasNext());
                        break;
                    case "Print":
                        myList.Print();
                        break;
                    case "PrintAll":
                        foreach (var item in myList)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
