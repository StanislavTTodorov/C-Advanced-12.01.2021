using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private int age;
        private string name;

        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age)
            :this()
        {
            Age = age;
        }
        public Person(string name,int age)
            :this(age)
        {
            Name = name;
        }

        public  int  Age 
        {
            get => this.age;
            set => this.age = value;
        }

        public string Name 
        {
            get => this.name;
            set => this.name = value; 
        }
 
    }
}
