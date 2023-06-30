using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
     public class Family
     {
        public Family()
        {
            Members = new List<Person>();
        }

        public List<Person> Members { get; set; }

        public void AddMember(Person person)
        {
            Members.Add(person);
        }
        public Person GetOldestMember()
        {
            Person person = Members.OrderByDescending(n => n.Age).FirstOrDefault();
            return person;          
        }
        public void Print(Person person)
        {
            Console.WriteLine($"{person.Name} {person.Age}");
        }
    }
}
