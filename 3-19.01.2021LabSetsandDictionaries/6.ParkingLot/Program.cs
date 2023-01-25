using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _6.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] commands = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0].ToUpper();
                string carNumber = commands[1];
                if (command == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    carNumbers.Remove(carNumber);
                }
                input = Console.ReadLine();
            }
            if (carNumbers.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in carNumbers)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
