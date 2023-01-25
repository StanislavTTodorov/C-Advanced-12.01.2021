using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudent = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> dicionaryOfStudent = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < numberOfStudent; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = studentInfo[0];
                decimal grades = decimal.Parse(studentInfo[1]);
                if (dicionaryOfStudent.ContainsKey(name))
                {
                    dicionaryOfStudent[name].Add(grades);
                }
                else
                {
                    dicionaryOfStudent.Add(name, new List<decimal> { grades });
                }
            }
            foreach (var name in dicionaryOfStudent)
            {
                Console.Write($"{name.Key} -> ");
                foreach (var grade in name.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {name.Value.Average():f2})");
            }
        }
    }
}
