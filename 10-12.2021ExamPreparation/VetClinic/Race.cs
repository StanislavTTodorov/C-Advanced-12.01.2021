using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Race
    {
        private string name;
        List<Racer> list;
        

        private int capacity;
        public Race(int capacity)
        {
            list = new List<Racer>(capacity);
            List = list;
        }

        public Race(string name, int capacity)
            :this(capacity)
        {
            this.name = name;
            this.capacity = capacity;
            Name = this.name;
            Capacity = this.capacity;
        }
       
        public string Name { get; set; }

        public void Add(Racer racer1)
        {
            if (List.Count < Capacity)
            {
                List.Add(racer1);
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

      
        internal Racer GetRacer(string v)
        {
            List<Racer> filrer = List.Where(n => n.Name == v).ToList();
            return filrer[0];
        }

        public Racer GetOldestRacer()
        {
            List<Racer> filrer = List.OrderByDescending(n => n.Age).ToList();

            return filrer[0];
        }
        public int Count => List.Count;

        public int Capacity { get; set; }

        public List<Racer> List { get; set; }

     
    }
}