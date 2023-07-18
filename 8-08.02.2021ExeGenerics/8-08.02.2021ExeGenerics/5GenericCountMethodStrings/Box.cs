using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5GenericCountMethodStrings
{
    public class Box<T>
        where T: IComparable
    {
        private List<T> list;
        public Box()
        {
            list = new List<T>();   
        }
        public void Add(T element)
        {            
            Value = element;
            list.Add(Value);
        }

        public int GetCount(T element)
        {
            int count = 0;
            //double elementNumber = double.Parse(element.ToString());
            foreach (var item in list)
            {
                //double number = double.Parse(item.ToString());
                if (item.CompareTo(element)>0)
                {
                    count++;
                }
            }
            return count;
        }
        public T Value { get; set; }
    }
}
