using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
   public class Clinic
    {
        private List<Pet> listedPets;
        public Clinic()
        {
            listedPets = new List<Pet>();
            ListedPets = listedPets;
        }

        public Clinic(int size)
        {
            Capacity = size;
            listedPets = new List<Pet>(Capacity);
            ListedPets = listedPets;  
        }

        public List<Pet> ListedPets { get; set; }

        public int Capacity { get; set; }

        public void Add(Pet dog)
        {
            if (listedPets.Count<Capacity)
            {
                ListedPets.Add(dog);
            }        
        }
        public int Count => ListedPets.Count;
       
        public bool Remove(string name)
        {
            bool isЕxists = false;
            int count = -1;
            foreach (var item in ListedPets)
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
                ListedPets.RemoveAt(count);
            }           
            return isЕxists;
        }

        public Pet GetOldestPet()
        {
            List<Pet> filrer = ListedPets.OrderByDescending(n => n.Age).ToList();

            return filrer[0];
        }

        public string GetStatistics()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("The clinic has the following patients:");
            foreach (var item in ListedPets)
            {
                stringBuilder.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }
            return string.Join(Environment.NewLine, stringBuilder);
        }    

        public Pet GetPet(string name, string owner)
        {
            bool isЕxists = true;
            int count = -1;
            foreach (var item in ListedPets)
            {
                count++;
                if (item.Name == name && item.Owner == owner)
                {
                    isЕxists = false;
                    break;
                }
            }
            if (isЕxists)
            {
                return ListedPets[count];
            }
            else
            {
                return null;
            }
        }
    }
}
