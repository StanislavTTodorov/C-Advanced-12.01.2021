using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> partyList = new HashSet<string>();
            HashSet<string> partyVIPList = new HashSet<string>();
            while (input != "PARTY")
            {
                if (input[0] == '1' || input[0] == '2' || input[0] == '3' || input[0] == '4' || input[0] == '5' ||
                    input[0] == '6' || input[0] == '7' || input[0] == '8' || input[0] == '9' || input[0] == '0')
                {
                    partyVIPList.Add(input);
                }
                else
                {
                    partyList.Add(input);
                }            
                input = Console.ReadLine();           }
            input = Console.ReadLine();
            while (input != "END")
            {
                Contains(partyList, input);
                Contains(partyVIPList, input);
                input = Console.ReadLine();
            }
            Console.WriteLine(partyList.Count + partyVIPList.Count);
            Print(partyVIPList);
            Print(partyList);
        }
        private static void Contains(HashSet<string> list, string input)
        {
            if (list.Contains(input))
            {
                list.Remove(input);
            }
        }
        private static void Print(HashSet<string> list)
        {
            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}