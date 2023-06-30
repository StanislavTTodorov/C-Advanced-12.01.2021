using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < numberOfPeople; i++)
            {
                
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name,age);
                people.Add(person);
            }
            List<Person> filteredPeople = people
                .Where(a => a.Age > 30)
                .OrderBy(n => n.Name)
                .ToList();
            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
