using System;
using System.Collections.Generic;

namespace _5.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<Peopole> peopoles = new List<Peopole>();
            for (int i = 0; i < numberOfLines; i++)
            {
                Peopole peopole = new Peopole();
                string[] info = Console.ReadLine().Split(", ");
                peopole.Name = info[0];
                peopole.Age = int.Parse(info[1]);
                peopoles.Add(peopole);
            }
            string filter = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Peopole, string> formatCondition = GetFormatCondition(format);
            Func<Peopole, bool> condition = GetAgeCondition(filter, age);
            PrintPeople(peopoles,condition,formatCondition);
        }

        private static Func<Peopole, string> GetFormatCondition(string format)
        {
            switch (format)
            {
                case "name age":
                    return p => $"{p.Name} - {p.Age}";
                case "name":
                    return p => $"{p.Name}";
                case "age":
                    return p => $"{p.Age}";
                default:
                    return null;
            }
        }

        static void PrintPeople(List<Peopole> peoples,Func<Peopole,bool> condition,Func<Peopole,string> formatCondition)
        {
            foreach (var person in peoples)
            {
                if (condition(person))
                {
                    Console.WriteLine(formatCondition(person));
                }
            }
        }
        static Func<Peopole, bool> GetAgeCondition(string filter, int age)
        {
            switch (filter)
            {
                case "younger":
                    return p => p.Age < age;
                case "older":
                    return p => p.Age >= age;
                default:
                    return null;
            }
        }

    }
    
    class Peopole
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
