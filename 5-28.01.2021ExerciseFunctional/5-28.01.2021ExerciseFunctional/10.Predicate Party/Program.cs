using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string inputData = Console.ReadLine();

            while (inputData != "Party!")
            {
                string[] commands = inputData.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Func<string, bool> criteri = Criteri(commands);
                names = PartyList(names, criteri, commands[0]);
                inputData = Console.ReadLine();
            }
            string text = (names.Count > 0) ? $"{string.Join(", ", names)} are going to the party!" : "Nobody is going to the party!";
            Console.WriteLine(text);
        }
        private static List<string> PartyList(List<string> names, Func<string, bool> criteri, string command)
        {
            List<string> list = new List<string>();
            list = names.Where(criteri).ToList();
            foreach (var name in list)
            {
                if (command == "Double")
                {
                    int index = names.IndexOf(name);
                    names.Insert(index, name);
                }
                else if (command == "Remove")
                {
                    names.Remove(name);
                }
            }
            return names;
        }
        private static Func<string, bool> Criteri(string[] commands)
        {
            switch (commands[1])
            {
                case "StartsWith":
                    return n => n.StartsWith(commands[2]);
                case "EndsWith":
                    return n => n.EndsWith(commands[2]);
                case "Length":
                    return n => n.Length == int.Parse(commands[2]);
                default:
                    return null;
            }
        }
    }
}
