using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> partyNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, List<string>> reservation = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "Print")
            {
                string[] commands = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "Add filter":
                        Add(commands, reservation);
                        break;
                    case "Remove filter":
                        Remove(commands, reservation);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            List<string> filtersPartyList = PrintList(partyNames, reservation);
           // partyNames = partyNames.Except(filtersPartyList).ToList();
            Console.WriteLine(string.Join(" ", filtersPartyList));
        }

        private static List<string> PrintList(List<string> partyNames, Dictionary<string, List<string>> reservation)
        {
            List<string> list = new List<string>();
            foreach (var fitilter in reservation)
            {
                foreach (var parameter in fitilter.Value)
                {
                    partyNames = partyNames.Where(GetFilter(reservation, fitilter.Key, parameter)).ToList();
                    //list = list.Union(partyNames.Where(GetFilter(reservation, fitilter.Key, parameter)).ToList()).ToList();
                }
            }
            return list = partyNames;
        }

        private static Func<string, bool> GetFilter(Dictionary<string, List<string>> reservation, string fitilterType, string parameter)
        {
            switch (fitilterType)
            {
                case "Starts with":
                    return n => !n.StartsWith(parameter);
                case "Ends with":
                    return n => !n.EndsWith(parameter);
                case "Length":
                    return n => n.Length != int.Parse(parameter);
                case "Contains":
                    return n => !n.Contains(parameter);
                default:
                    return null;
            }
        }

        private static void Remove(string[] commands, Dictionary<string, List<string>> reservation)
        {
            string filterType = commands[1];
            string filterParameter = commands[2];
            if (reservation.ContainsKey(filterType) && reservation[filterType].Contains(filterParameter))
            {
                if (reservation[filterType].Count == 1)
                {
                    reservation.Remove(filterType);
                }
                else
                {
                    reservation[filterType].Remove(filterParameter);
                }
            }
        }

        private static void Add(string[] commands, Dictionary<string, List<string>> reservation)
        {
            string filterType = commands[1];
            string filterParameter = commands[2];
            if (reservation.ContainsKey(filterType) && !reservation[filterType].Contains(filterParameter))
            {
                reservation[filterType].Add(filterParameter);
            }
            else
            {
                reservation.Add(filterType, new List<string>() { filterParameter });
            }
        }
    }
}
