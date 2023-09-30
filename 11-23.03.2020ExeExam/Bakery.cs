using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Employee> List { get; set; }
        public int Count => List.Count();

        public void Add(Employee employee)
        {
            if (List.Count<Capacity)
            {
                List.Add(employee);
            }
            
        }

        public bool Remove(string name)
        {
            bool isЕxists = false;
            int count = -1;
            foreach (var item in List)
            {
                count++;
                if (item.Name == name)
                {
                    isЕxists = true;
                    break;
                }
            }
            if (isЕxists)
            {
                List.RemoveAt(count);
            }
            return isЕxists;
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = List.Where(n=>n.Name==name).First();
           
            return employee;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Employees working at Bakery {Name}:");
            foreach (var item in List)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            return stringBuilder.ToString();
        }

        public Employee GetOldestEmployee()
        {
            Employee employee = null;
            foreach (var item in List.OrderByDescending(n=>n.Age).Take(1))
            {
               employee = item;
            };
            return employee;
        }
    }
}